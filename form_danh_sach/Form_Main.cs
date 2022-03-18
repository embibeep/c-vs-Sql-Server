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

        private void Connection()
        {
            //Kết nối database vào qua hàm Connection.
            //Tạo database tên STUDENT, tạo  table Student có chưa các thuộc tính cần thiết.
            SqlConnection Connection = new SqlConnection("server=.;database=STUDENT;integrated security=true");
            SqlCommand cmd = new SqlCommand("Select * From Student", Connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            BindingSource binding = new BindingSource();
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
    }
}
