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
using System.IO;

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
            //đường dẫn url chỉ đúng khi sử dụng tại laptop chỉ định, nếu sử dụng trên thiết bị khác, hãy đôi đường dẫn file lại.
            String url = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\nam3\\sql\\SQL_Server_01\\Kiemtra\\Kiemtra\\bin\\Debug\\Database.accdb";
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
            //Mở Sql Server ra, tạo 1 database tên HOADON, và user ngoc,mật khẩu 06122001 để chạy thành công.
            String connectionstring;
            SqlConnection cnn;
            //thay đổi tên Server tùy vào từng máy, kiểm tra tên server khi mở Sql Server và nhập vào dòng Server phía dưới.
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
            //Mở Sql Server ra, tạo 1 database tên HOADON, và user ngoc,mật khẩu 06122001 để chạy thành công.
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
            //đường dẫn url chỉ đúng khi sử dụng tại laptop chỉ định, nếu sử dụng trên thiết bị khác, hãy đôi đường dẫn file lại.
            String filename = @"E:\\nam3\\sql\\SQL_Server_01\\Kiemtra\\Kiemtra\\bin\\Debug\\Database.xlsx";
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

        public void write()
        {
            File.AppendAllLines("text.txt", new string[] { "\nServer = SqlServer... \n" + "database=HOADON \n" + "uid=ngoc \n"+"pwd=06122001 \n"}) ;
        }
        private void btnSave_String_Click(object sender, EventArgs e)
        {
            try
            {
                write();
                MessageBox.Show("Đã tạo file thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tạo file thất bại! \n "+ex.Message);
            }
        }

        public string get_String()
        {
            //đường dẫn url chỉ đúng khi sử dụng tại laptop chỉ định, nếu sử dụng trên thiết bị khác, hãy đôi đường dẫn file lại.
            string fileName = @"E:\\nam3\\sql\\SQL_Server_01\\Kiemtra\\Kiemtra\\bin\\Debug\\text.txt";
            string s;
            StreamReader rd = new StreamReader(fileName);
            s = rd.ReadToEnd();
            rd.Close();
            return s;
        }

        private void btnRead_String_Click(object sender, EventArgs e)
        {
            try
            {
                string ctn = get_String();
                MessageBox.Show(ctn);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Đọc file thất bại! \n" + ex.Message);
            }
            //SqlConnection cnn = new SqlConnection();
            //cnn.ConnectionString = ctn;
            //try
            //{
            //    cnn.Open();
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show("Đọc file thành công!");
            //}
        }
    }
}
