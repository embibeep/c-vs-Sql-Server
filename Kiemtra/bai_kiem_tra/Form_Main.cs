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

        SqlDataAdapter da,daCha,daCon;
        SqlCommand cmd, cmdCha, cmdCon;
        DataTable dt = new DataTable();
        BindingSource binding = new BindingSource();
        SqlCommandBuilder cmb;
        DataSet ds;
        private void Connection()
        {
            //Kết nối database vào qua hàm Connection.
            //Tạo database tên STUDENT, tạo  table Student có chưa các thuộc tính cần thiết.
            SqlConnection Connection = new SqlConnection("server=.;database=HOADON;integrated security=true");
            cmd = new SqlCommand("Select * From MatHang FULL OUTER JOIN LoaiHang ON MatHang.MaLH=LoaiHang.MaLH", Connection);
            da = new SqlDataAdapter(cmd);
            //DataTable dt;
            da.Fill(dt);
            binding.DataSource = dt;
            dgv_Staff.DataSource = binding;
            //cmdCha = new SqlCommand("select * from " + LoaiHang, Connection.cnn);
            //daCha = new SqlDataAdapter(cmdCha);
            //cmdCon = new SqlCommand("select * from " + MatHang, Connection.cnn);
            //daCon = new SqlDataAdapter(cmdCon);
            //ds = new DataSet();
            //daCha.Fill(ds, LoaiHang);
            //daCon.Fill(ds, MatHang);

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
                txt_MaMH.Text = dgv_Staff.CurrentRow.Cells["MaMH"].Value.ToString();
                txt_TenMH.Text = dgv_Staff.CurrentRow.Cells["TenMH"].Value.ToString();
                txt_DonViTinh.Text = dgv_Staff.CurrentRow.Cells["DonViTinh"].Value.ToString();
                txt_DonGia.Text = dgv_Staff.CurrentRow.Cells["DonGia"].Value.ToString();
                txt_SoTon.Text = dgv_Staff.CurrentRow.Cells["SoTon"].Value.ToString();
                txt_MaLH.Text = dgv_Staff.CurrentRow.Cells["MaLH"].Value.ToString();
                txt_Loai.Text = dgv_Staff.CurrentRow.Cells["TenLH"].Value.ToString();
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
            cmd1.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = txt_MaMH.Text;
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
            cmd1.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = txt_MaMH.Text;
            cmd1.Parameters.Add("@Ho", SqlDbType.NVarChar).Value = txt_TenMH.Text;
            cmd1.Parameters.Add("@Ten", SqlDbType.NVarChar).Value = txt_DonViTinh.Text;
            cmd1.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = txt_DonGia.Text;
            cmd1.Parameters.Add("@LuongCB", SqlDbType.NVarChar).Value = txt_SoTon.Text;
            cmd1.Parameters.Add("@CongViec", SqlDbType.NVarChar).Value = txt_MaLH.Text;
            cmd1.Parameters.Add("@MaKV", SqlDbType.NVarChar).Value = txt_Loai.Text;

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
