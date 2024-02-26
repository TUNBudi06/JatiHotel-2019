using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JatiHotel
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        Utils conn = new Utils();

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox_password.Text) || string.IsNullOrEmpty(textBox_Username.Text)) 
            { 
                MessageBox.Show("Please fill the empty box","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection sqls = conn.koneksi())
            {
                try
                {
                    sqls.Open();
                    string query = "select * from Employee where Username = @user AND Password = @pw";
                    SqlCommand sqlc = sqls.CreateCommand();

                    sqlc.CommandType = CommandType.Text;
                    sqlc.CommandText = query;
                    sqlc.Parameters.AddWithValue("@user", textBox_Username.Text);
                    sqlc.Parameters.AddWithValue("@pw", textBox_password.Text);

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = sqlc;
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 1)
                    {
                        MessageBox.Show("successfully login", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MainForm main = new MainForm();
                        this.Hide();
                        main.Show();
                    } else
                    {
                        MessageBox.Show("Password or Username wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox_Username.Focus();
                    }
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    sqls.Close();
                }
            }
        }
    }
}
