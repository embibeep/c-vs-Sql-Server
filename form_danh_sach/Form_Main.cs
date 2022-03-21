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

namespace form_danh_sach
{
    public partial class Form_Main : Form
    {
        public Form_Main()
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
            SqlConnection Connection = new SqlConnection("server=.;database=STUDENT;integrated security=true");
            cmd = new SqlCommand("Select * From Student", Connection);
            da = new SqlDataAdapter(cmd);
            //DataTable dt;
            da.Fill(dt);
            binding.DataSource = dt;
            dgv_Staff.DataSource = binding;
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            //load data ngay khi chạy chương trình.
            Connection();
        }


        private void btn_Edit_Click(object sender, EventArgs e)
        {

        }

        private void dgv_Staff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                //các thuộc tính trong ngoặc vuông có thể thay đổi tùy theo tên biến trong database.
                txt_MaNV.Text = dgv_Staff.CurrentRow.Cells["MaNV"].Value.ToString();
                txt_Ho.Text = dgv_Staff.CurrentRow.Cells["Ho"].Value.ToString();
                txt_Ten.Text = dgv_Staff.CurrentRow.Cells["Ten"].Value.ToString();
                txt_GioiTinh.Text = dgv_Staff.CurrentRow.Cells["GioiTinh"].Value.ToString();
                txt_LuongCB.Text = dgv_Staff.CurrentRow.Cells["LuongCB"].Value.ToString();
                txt_CongViec.Text = dgv_Staff.CurrentRow.Cells["CongViec"].Value.ToString();
                txt_MaKV.Text = dgv_Staff.CurrentRow.Cells["MaKV"].Value.ToString();
            }
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            tbl = dt.GetChanges();
            if(tbl == null)
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

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection("server=.;database=STUDENT;integrated security=true");
            string SCon;
            SCon = "Delete From Student Where MaNV = @MaNV";
            SqlCommand cmd1 = new SqlCommand(SCon,Connection);
            Connection.Open();
            cmd1.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = txt_MaNV.Text;
            int count = cmd1.ExecuteNonQuery();
            if (count > 0)
            {
                DataRowView row = (DataRowView)binding.Current;
                row.Delete();
                MessageBox.Show("Xóa thành công!");
            }
            Connection.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection("server=.;database=STUDENT;integrated security=true");
            string Scon;
            Connection.Open();
            Scon = "insert into Student values(@MaNV,@Ho,@Ten,@GioiTinh,@LuongCB,@CongViec,@MaKV)";
            SqlCommand cmd1 = new SqlCommand(Scon, Connection);
            cmd1.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = txt_MaNV.Text;
            cmd1.Parameters.Add("@Ho", SqlDbType.NVarChar).Value = txt_Ho.Text;
            cmd1.Parameters.Add("@Ten", SqlDbType.NVarChar).Value = txt_Ten.Text;
            cmd1.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = txt_GioiTinh.Text;
            cmd1.Parameters.Add("@LuongCB", SqlDbType.NVarChar).Value = txt_LuongCB.Text;
            cmd1.Parameters.Add("@CongViec", SqlDbType.NVarChar).Value = txt_CongViec.Text;
            cmd1.Parameters.Add("@MaKV", SqlDbType.NVarChar).Value = txt_MaKV.Text;

            int count = cmd1.ExecuteNonQuery();
            {
                MessageBox.Show("Thêm thành công!");
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
