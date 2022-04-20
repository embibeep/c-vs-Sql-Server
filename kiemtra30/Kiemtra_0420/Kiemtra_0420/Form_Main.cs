using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiemtra_0420
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void btn_Bai1_Click(object sender, EventArgs e)
        {
            Bai1 bai1 = new Bai1();
            bai1.ShowDialog();
        }

        private void btn_Bai2_Click(object sender, EventArgs e)
        {
            Bai2 bai2 = new Bai2();
            bai2.ShowDialog();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
