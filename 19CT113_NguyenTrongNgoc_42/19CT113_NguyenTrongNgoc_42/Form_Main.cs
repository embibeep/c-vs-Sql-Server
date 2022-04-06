using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19CT113_NguyenTrongNgoc_42
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cau_1_Click(object sender, EventArgs e)
        {
            Form_Cau_1 cau1 = new Form_Cau_1();
            cau1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Cau_2 cau2 = new Form_Cau_2();
            cau2.ShowDialog();
        }
    }
}
