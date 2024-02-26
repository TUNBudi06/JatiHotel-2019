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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
        Utils conn = new Utils();
        private string foto;
        private bool updateData = false;
        public int ID_user;

        public void loadtable()
        {
            using (SqlConnection sqls = conn.koneksi())
            {
                try
                {
                    sqls.Open();
                    SqlCommand sqlc = sqls.CreateCommand();

                    sqlc.CommandType = CommandType.Text;
                    sqlc.CommandText = "select * from employee";

                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = sqlc;
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    
                    if (dataGridView_employee.Rows.Count > 0)
                    {
                        dataGridView_employee.Columns.Clear();
                    }
                    dataGridView_employee.DataSource = dt;
                    dataGridView_employee.Columns["ID"].Visible = false;
                    dataGridView_employee.AllowUserToAddRows = false;
                    DataGridViewButtonColumn ubah = new DataGridViewButtonColumn();
                    DataGridViewButtonColumn hapus = new DataGridViewButtonColumn();
                    ubah.Name = "ubahData";
                    hapus.Name = "hapusData";
                    ubah.Text = "Edit";
                    hapus.Text = "Delete";
                    ubah.UseColumnTextForButtonValue = true;
                    hapus.UseColumnTextForButtonValue = true;
                    dataGridView_employee.Columns.Insert(dataGridView_employee.ColumnCount,ubah);
                    dataGridView_employee.Columns.Insert(dataGridView_employee.ColumnCount,hapus);

                } finally { sqls.Close(); }
            }
        }

        public  void Loadtext()
        {
            using (SqlConnection sqls = conn.koneksi())
            {
                try
                {
                    sqls.Open();

                    SqlCommand cmd = sqls.CreateCommand();
                    cmd.CommandText = "select * from Job";
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = cmd;

                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    comboBox_Job.DataSource = dt;
                    comboBox_Job.DisplayMember = "Name";
                    comboBox_Job.ValueMember = "ID";

                } finally { sqls.Close(); }
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            loadtable();
            Loadtext();
            buttoncontroller();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "select Any Picture";
            ofd.Multiselect = false;
            ofd.InitialDirectory = @"c:\";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foto = ofd.FileName;
                Console.WriteLine(foto);
                pictureBox_foto.Image = Image.FromFile(foto);
            }
        }
        
        public void buttoncontroller()
        {
            if(updateData)
            {
                button_insert.Enabled = false;
                button_delete.Enabled = true;
                button_save.Enabled = true;
                button_update.Enabled = true;
                button_cancel.Enabled = true;
            } else
            {
                button_insert.Enabled = true;
                button_delete.Enabled = false;
                button_save.Enabled = true;
                button_update.Enabled = false;
                button_cancel.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrEmpty(textBox_username.Text) || string.IsNullOrEmpty(textBox_password.Text) || string.IsNullOrEmpty(textBox_name.Text) 
                || string.IsNullOrEmpty(textBox_email.Text) || string.IsNullOrEmpty(richTextBox_address.Text) || string.IsNullOrEmpty(foto)
                ) { 
                MessageBox.Show("please fill the empty boxs","error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(textBox_password.Text != textBox_cpassword.Text)
            {
                MessageBox.Show("Password and Confirm Password doesnt match","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (!updateData)
            {
                using (SqlConnection sqls = conn.koneksi())
                {
                    try
                    {
                        sqls.Open();

                        SqlCommand cmd = sqls.CreateCommand();
                        cmd.CommandText = "insert into employee(Username,Password,Name,Email,Address,DateOfBirth,JobID,Photo) " +
                            "values (@un,@pw,@name,@email,@Address,@dob,@jid,@photo);";


                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@un", textBox_username.Text);
                        cmd.Parameters.AddWithValue("@pw", textBox_password.Text);
                        cmd.Parameters.AddWithValue("@name", textBox_name.Text);
                        cmd.Parameters.AddWithValue("@email", textBox_email.Text);
                        cmd.Parameters.AddWithValue("@Address", richTextBox_address.Text);
                        cmd.Parameters.AddWithValue("@jid", comboBox_Job.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@dob", dateTimePicker_dob.Value.ToString("MM-dd-yyyy"));
                        cmd.Parameters.AddWithValue("@photo", foto);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("successfully added data", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("adding data failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    finally
                    {
                        clearinput();
                        loadtable();
                        sqls.Close();
                    }
                }
            }
        }

        private void clearinput()
        {
            updateData = false;
            textBox_email.Clear();
            textBox_password.Clear();
            textBox_name.Clear();
            textBox_cpassword.Clear();
            richTextBox_address.Clear();
            dateTimePicker_dob.Value = DateTime.Now;
            pictureBox_foto.Image = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clearinput();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_username.Text) || string.IsNullOrEmpty(textBox_password.Text) || string.IsNullOrEmpty(textBox_name.Text)
                || string.IsNullOrEmpty(textBox_email.Text) || string.IsNullOrEmpty(richTextBox_address.Text) || string.IsNullOrEmpty(foto)
                )
            {
                MessageBox.Show("please fill the empty boxs", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox_password.Text != textBox_cpassword.Text)
            {
                MessageBox.Show("Password and Confirm Password doesnt match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!updateData)
            {
                using (SqlConnection sqls = conn.koneksi())
                {
                    try
                    {
                        sqls.Open();

                        SqlCommand cmd = sqls.CreateCommand();
                        cmd.CommandText = "insert into employee(Username,Password,Name,Email,Address,DateOfBirth,JobID,Photo) " +
                            "values (@un,@pw,@name,@email,@Address,@dob,@jid,@photo);";


                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@un", textBox_username.Text);
                        cmd.Parameters.AddWithValue("@pw", textBox_password.Text);
                        cmd.Parameters.AddWithValue("@name", textBox_name.Text);
                        cmd.Parameters.AddWithValue("@email", textBox_email.Text);
                        cmd.Parameters.AddWithValue("@Address", richTextBox_address.Text);
                        cmd.Parameters.AddWithValue("@jid", comboBox_Job.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@dob", dateTimePicker_dob.Value.ToString("MM-dd-yyyy"));
                        cmd.Parameters.AddWithValue("@photo", foto);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("successfully added data", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("adding data failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    finally
                    {
                        clearinput();
                        loadtable();
                        sqls.Close();
                    }
                }
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_username.Text) || string.IsNullOrEmpty(textBox_password.Text) || string.IsNullOrEmpty(textBox_name.Text)
                || string.IsNullOrEmpty(textBox_email.Text) || string.IsNullOrEmpty(richTextBox_address.Text) || string.IsNullOrEmpty(foto)
                )
            {
                MessageBox.Show("please fill the empty boxs", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox_password.Text != textBox_cpassword.Text)
            {
                MessageBox.Show("Password and Confirm Password doesnt match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!updateData)
            {
                using (SqlConnection sqls = conn.koneksi())
                {
                    try
                    {
                        sqls.Open();

                        SqlCommand cmd = sqls.CreateCommand();
                        cmd.CommandText = "update Employee set Username = @un, Password = @pw,Name = @name, Email = @email,Address = @Address,DateOfBirth = @dob,JobID = @jid,photo = @photo where ID = @id;";


                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@un", textBox_username.Text);
                        cmd.Parameters.AddWithValue("@pw", textBox_password.Text);
                        cmd.Parameters.AddWithValue("@name", textBox_name.Text);
                        cmd.Parameters.AddWithValue("@email", textBox_email.Text);
                        cmd.Parameters.AddWithValue("@Address", richTextBox_address.Text);
                        cmd.Parameters.AddWithValue("@jid", comboBox_Job.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@dob", dateTimePicker_dob.Value.ToString("MM-dd-yyyy"));
                        cmd.Parameters.AddWithValue("@photo", foto);
                        cmd.Parameters.AddWithValue("@id", ID_user);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("successfully Update data", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("update data failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    finally
                    {
                        clearinput();
                        loadtable();
                        sqls.Close();
                    }
                }
            }
        }
    }
}
