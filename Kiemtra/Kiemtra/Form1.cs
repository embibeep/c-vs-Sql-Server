using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Configuration;

namespace Kiemtra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void btnAccess_Click(object sender, EventArgs e)
        {
            OleDbConnection odc;
            String url = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Z:\\19CT113_15_NguyenTrongNgoc\\Kiemtra\\Kiemtra\\bin\\Debug\\Database.accdb";
            odc = new OleDbConnection(url);
            try
            {
                odc.Open();
                MessageBox.Show("Kết nối thành công");
                odc.Close();
            }
            catch (Exception exx)
            {
                MessageBox.Show("Lỗi kết nối! \n" + exx.Message);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            String connectionstring;
            SqlConnection cnn;
            connectionstring = "Server=P0942;Database=HOADON;Uid=ngoc;PWD=06122001";
            cnn = new SqlConnection(connectionstring);
            {
                try
                {
                    if (rdwin.Checked == true)
                    {
                        connectionstring = "Server=" + txtserver.Text;
                        connectionstring += "database=" + txtdatabase.Text;
                        connectionstring += "integrated security=SSPI";
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
                    MessageBox.Show("Kết nối thành công");
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối\n" + ex.Message);
                }
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            string Conn = ConfigurationManager.ConnectionStrings["SqlServer_"].ConnectionString;
            SqlConnection cnt = new SqlConnection(Conn);
            try
            {
                cnt.Open();
                MessageBox.Show("Kết nối thành công");
                cnt.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối \n" + ex.Message);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            String filename = @"Z:\\19CT113_15_NguyenTrongNgoc\\Kiemtra\\Kiemtra\\bin\\Debug\\Database.xlsx";
            String connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filename + ";Extended Properties=\"Excel 12.0 Xml;HDR=YES;\"";
            String Command = "Select * from [sheets$]";
            OleDbConnection con = new OleDbConnection(connection);
            try
            {
                con.Open();
                MessageBox.Show("Kết nối thành công");
                con.Close();
            }
            catch (Exception exx)
            {
                MessageBox.Show("Lỗi kết nối \n" + exx.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
