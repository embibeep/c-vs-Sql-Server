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

namespace form_khach_hang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string s;
            SqlCommand cmd = new SqlCommand();
            s = "insert into khachhang (makh, TenKH, DCKH, DTKH)";
            s += "values (@makh,@tenkh,@dckh,@dtkh)";
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = s;
            cmd.Parameters.Add("@makh",)
        }
    }
}
