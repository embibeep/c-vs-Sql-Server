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

namespace Form_khach_hang
{
    public partial class Form1 : Form
    {
        private SqlConnection cnn;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string s;
            SqlCommand cmd = new SqlCommand();
            s = "insert into khachhang (makh, TenKh, DCKH,DTKH)";
            s += "values(@makh,@tenkh,@dckh,@dtkh)";
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = s;
            cmd.Parameters.Add("@makh", SqlDbType.Float).Value = float.Parse(txtCode.Text);
            cmd.Parameters.Add("@tenkh", SqlDbType.VarChar).Value = txtName.Text;
            cmd.Parameters.Add("@dckh", SqlDbType.VarChar).Value = txtAddress.Text;
            cmd.Parameters.Add("@dtkh", SqlDbType.VarChar).Value = txtNumber.Text;
            cmd.CommandTimeout = 60;
            cmd.ExecuteNonQuery();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string s;
            SqlCommand cmd = new SqlCommand();
            s = "delete from KhachHang where makh = @makh";
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = s;
            cmd.Parameters.Add("@makh", SqlDbType.Float).Value = float.Parse(txtCode.Text);
            cmd.CommandTimeout = 60;
            cmd.ExecuteNonQuery();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select count(*) from KhachHang";
            cmd.CommandTimeout = 60;
            cmd.Connection = cnn;
            int i = (int)cmd.ExecuteScalar();
            MessageBox.Show(i.ToString());
        }

        private void btnWatch_Click(object sender, EventArgs e)
        {
            string s;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from KhachHang";
            cmd.CommandTimeout = 60;
            cmd.Connection = cnn;
            SqlDataReader rs;
            rs = cmd.ExecuteReader();
            int i;
            i = rs.FieldCount;
            s= rs.GetDataTypeName(1).ToString() + " - " + rs.GetName(1) + "= \n";
            while(rs.Read())
            {
                for (i=0;i<rs.FieldCount;i++)
                {
                    s += " " + rs.GetValue(i);
                }
                s += "\n";
            }
            MessageBox.Show(s);
            rs.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
