using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JatiHotel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public Form loadForm(object form)
        {
            if(this.panel_main.Controls.Count > 0)
            {
                this.panel_main.Controls.RemoveAt(0);
            }

            Form fview =  form as Form;
            fview.TopLevel = false;
            fview.Dock = DockStyle.Fill;
            panel_main.Controls.Add(fview);
            panel_main.Tag = fview;
            fview.Show();
            return fview;
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void logoutSysterm()
        {
            Application.Run(new LoginForm());
        }

        private void toolStripButton_LogOut_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("do you sure want to logout?","Question",MessageBoxButtons.OKCancel,MessageBoxIcon.Information) == DialogResult.OK)
            {
                System.Threading.Thread trd = new System.Threading.Thread(new System.Threading.ThreadStart(logoutSysterm));
                this.Close();
                trd.Start();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("do you sure want to logout?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                System.Threading.Thread trd = new System.Threading.Thread(new System.Threading.ThreadStart(logoutSysterm));
                this.Close();
                trd.Start();
            }
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                Thread.Sleep(1000);
                string date = DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss");
                toolStripLabel_tanggal.Text = date;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripLabel_tanggal.Text = DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss");
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fview = loadForm(new Employee());
        }
    }
}
