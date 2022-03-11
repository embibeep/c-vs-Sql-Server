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

namespace SQL_Server_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            String connectionstring;
            SqlConnection cnn;
            connectionstring = "Server=P0942;Database=HOADON;Uid=admin;PWD=123456789";
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection odc;
            String url="Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\PM\\Downloads\\c-vs-Sql-Server\\bin\\Debug\\Database.accdb";
            odc = new OleDbConnection(url);
            try
            {
                odc.Open();
                MessageBox.Show("Kết nối thành công!");
                odc.Close();
            }
            catch (Exception exx)
            {
                MessageBox.Show("Lỗi kết nối! \n" + exx.Message);
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            string Conn = ConfigurationManager.ConnectionStrings["SqlServer"].ConnectionString;
            SqlConnection cnt = new SqlConnection(Conn);
            try
            {
                cnt.Open();
                MessageBox.Show("Kết nối thành công");
                cnt.Close();
            } catch (Exception ex){
                MessageBox.Show("Lỗi kết nối \n" + ex.Message);
            }
        }
    }    
}

