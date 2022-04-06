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

namespace _19CT113_NguyenTrongNgoc_42
{
    public partial class Form_Cau_2 : Form
    {
        public Form_Cau_2()
        {
            InitializeComponent();
        }

        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        BindingSource binding = new BindingSource();
        SqlCommandBuilder cmb;

        private void Connection()
        {
            //Kết nối database vào qua hàm Connection.
            //Tạo database tên STUDENT, tạo  table Student có chưa các thuộc tính cần thiết.
            SqlConnection Connection = new SqlConnection("server=.;database=TheThao;integrated security=true");
            cmd = new SqlCommand("Select * From CLB", Connection);
            da = new SqlDataAdapter(cmd);
            //DataTable dt;
            da.Fill(dt);
            binding.DataSource = dt;
            dgv_Staff_2.DataSource = binding;
        }

        private void Form_Cau_2_Load(object sender, EventArgs e)
        {
            Connection();
        }

        private void dgv_Staff_2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                //các thuộc tính trong ngoặc vuông có thể thay đổi tùy theo tên biến trong database.
                txt_MaCLB.Text = dgv_Staff_2.CurrentRow.Cells["MaCLB"].Value.ToString();
                txt_TenCLB.Text = dgv_Staff_2.CurrentRow.Cells["TenCLB"].Value.ToString();
                txt_SoDoi.Text = dgv_Staff_2.CurrentRow.Cells["SoDoi"].Value.ToString();
            }
        }


        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            tbl = dt.GetChanges();
            if (tbl == null)
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
            else
            {
                cmb = new SqlCommandBuilder(da);
                da.Update(dt);
                MessageBox.Show("Có" + tbl.Rows.Count + " danh sách đã được cập nhật!");
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection("server=.;database=TheThao;integrated security=true");
            string Scon;
            Connection.Open();
            Scon = "insert into CLB values(@MaCLB,@TenCLB,@SoDoi)";
            SqlCommand cmd1 = new SqlCommand(Scon, Connection);
            cmd1.Parameters.Add("@MaCLB", SqlDbType.NVarChar).Value = txt_MaCLB.Text;
            cmd1.Parameters.Add("@TenCLB", SqlDbType.NVarChar).Value = txt_TenCLB.Text;
            cmd1.Parameters.Add("@SoDoi", SqlDbType.NVarChar).Value = txt_SoDoi.Text;

            int count = cmd1.ExecuteNonQuery();
            {
                MessageBox.Show("Thêm thành công!");
            }
            Connection.Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection("server=.;database=TheThao;integrated security=true");
            string SCon;
            SCon = "Delete From CLB Where MaCLB = @MaCLB";
            SqlCommand cmd1 = new SqlCommand(SCon, Connection);
            Connection.Open();
            cmd1.Parameters.Add("@MaCLB", SqlDbType.NVarChar).Value = txt_MaCLB.Text;
            int count = cmd1.ExecuteNonQuery();
            if (count > 0)
            {
                DataRowView row = (DataRowView)binding.Current;
                row.Delete();
                MessageBox.Show("Xóa thành công!");
            }
            Connection.Close();
        }

        private void btn_Edit_Dgv_Click(object sender, EventArgs e)
        {
            dt.Clear();
            da.Fill(dt);
        }


    }
}
