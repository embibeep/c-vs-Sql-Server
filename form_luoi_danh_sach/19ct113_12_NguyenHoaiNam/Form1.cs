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

namespace _19ct113_12_NguyenHoaiNam
{
    public partial class Form1 : Form
    {
        SqlConnection cnn = new SqlConnection();
        public Form1()
        {
            InitializeComponent();
            txtuser.Enabled = false;
            txtpass.Enabled = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string connectionstring;


            try
            {
                if (rdwin.Checked == true)
                {
                    connectionstring = "Server=" + txtserver.Text;
                    connectionstring += ";database=" + txtdatabase.Text;
                    connectionstring += ";integrated security=true";
                    cnn.ConnectionString = connectionstring;
                }
                else
                {
                    connectionstring = "Server=" + txtserver.Text;
                    connectionstring += ";database=" + txtdatabase.Text;
                    connectionstring += ";uid=" + txtuser.Text;
                    connectionstring += ";pwd=" + txtpass.Text;
                    cnn.ConnectionString = connectionstring;
                }
                cnn.Open();
                MessageBox.Show("ket noi thanh cong");

                this.Hide();
                ThongTin view = new ThongTin(cnn);
                view.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi ke noi" + ex.Message);
            }
        }
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đóng chương trình", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void rdwin_CheckedChanged(object sender, EventArgs e)
        {
            txtuser.Enabled = false;
            txtpass.Enabled = false;
            
        }

        private void rdsql_CheckedChanged(object sender, EventArgs e)
        {
            txtuser.Enabled = true;
            txtpass.Enabled = true;
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
