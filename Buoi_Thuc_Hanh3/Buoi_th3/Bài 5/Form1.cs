using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int a, b;

            if (!int.TryParse(txtN.Text, out a) || !int.TryParse(txtM.Text, out b))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
                return;
            }

            txtKetQua.Clear();

            if (rdoUCLN.Checked)
            {
                txtKetQua.AppendText($"UCLN({a}, {b}) = {TimUCLN(a, b)}\r\n");
            }

            if (rdoBCNN.Checked)
            {
                txtKetQua.AppendText($"BCNN({a}, {b}) = {TimBCNN(a, b)}\r\n");
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtN.Clear();
            txtM.Clear();
            txtKetQua.Clear();
            rdoUCLN.Checked = false;
            rdoBCNN.Checked = false;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
