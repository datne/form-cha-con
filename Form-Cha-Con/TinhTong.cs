using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Cha_Con
{
    public partial class TinhTong : Form
    {
        public TinhTong()
        {
            InitializeComponent();
        }

        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtN.Text))
            {
                MessageBox.Show("Nhập n đi nào !");
            }
            else
            {
                int n = int.Parse(txtN.Text);
                int kq = 0;
                for (int i = 1; i <= n; i++)
                {
                    kq = kq + i;
                }
                txtKetQuaTong.Text = kq.ToString();
            }
        }

        private void btnResetKq_Click(object sender, EventArgs e)
        {
            txtN.Text = "";
            txtKetQuaTong.Text = "";
        }
    }
}
