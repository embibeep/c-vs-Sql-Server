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

namespace Kiemtra_0420
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        BindingSource binding = new BindingSource();
        SqlCommandBuilder cmb;
        private SqlConnection cnn;
        private void Connection()
        {
            
            SqlConnection Connection = new SqlConnection("server=.;database=HoaDon;integrated security=true");
            cmd = new SqlCommand("Select * From CTDH", Connection);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            binding.DataSource = dt;
            dgv_CTDH.DataSource = binding;
        }

        private void Bai1_Load(object sender, EventArgs e)
        {
            Connection();
        }

        private void dgv_CTDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                //các thuộc tính trong ngoặc vuông có thể thay đổi tùy theo tên biến trong database.
                txt_SoHD.Text = dgv_CTDH.CurrentRow.Cells["SoHD"].Value.ToString();
                txt_MaMH.Text = dgv_CTDH.CurrentRow.Cells["MaMH"].Value.ToString();
                txt_SoLuong.Text = dgv_CTDH.CurrentRow.Cells["So Luong"].Value.ToString();
                txt_DGBan.Text = dgv_CTDH.CurrentRow.Cells["DG Ban"].Value.ToString();
            }
        }

        private void btn_Save_1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection Connection = new SqlConnection("server=.;database=HoaDon;integrated security=true");
                string Scon;
                Connection.Open();
                Scon = "insert into CTDH values(@SoHD,@MaMH,@So Luong,@DG Ban)";
                SqlCommand cmd1 = new SqlCommand(Scon, Connection);
                cmd.Parameters.Add("@SoHD", SqlDbType.Int).Value = int.Parse(txt_SoHD.Text);
                cmd.Parameters.Add("@MaMH", SqlDbType.Int).Value = int.Parse(txt_MaMH.Text);
                cmd.Parameters.Add("@So Luong", SqlDbType.Int).Value = int.Parse(txt_SoLuong.Text);
                cmd.Parameters.Add("@DG Ban", SqlDbType.Float).Value = float.Parse(txt_DGBan.Text);
                int count = cmd1.ExecuteNonQuery();
                {
                    MessageBox.Show("Thêm thành công!");
                }
                Connection.Close();
            }
            catch (Exception Exception)
            {
                MessageBox.Show("Chưa thêm thành công!");
            }
        }

        private void btn_Exit_1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Delete_1_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection("server=.;database=HoaDon;integrated security=true");
            string SCon;
            SCon = "Delete From CTDH Where SoHD = @SoHD";
            SqlCommand cmd1 = new SqlCommand(SCon, Connection);
            Connection.Open();
            cmd1.Parameters.Add("@SoHD", SqlDbType.Int).Value = txt_SoHD.Text;
            int count = cmd1.ExecuteNonQuery();
            if (count > 0)
            {
                DataRowView row = (DataRowView)binding.Current;
                row.Delete();
                MessageBox.Show("Xóa thành công!");
            }
            Connection.Close();
        }

        private void btn_Edit_1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng chưa được cập nhật!");
        }
    }
}
