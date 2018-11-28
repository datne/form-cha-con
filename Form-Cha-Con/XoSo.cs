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
    public partial class XoSo : Form
    {
        public XoSo()
        {
            InitializeComponent();
        }

        private void txtDaySoNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDaySoNhap_TextChanged(object sender, EventArgs e)
        {
            if (txtDaySoNhap.Text.Length == 6)
            {
                txtDaySoNhap.Enabled = false;
                btnQuaySo.Enabled = true;              
            }
        }

        private void btnQuaySo_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int s = r.Next(0, 10);
            txtSoQuay.Text = s.ToString();
            txtDaySoTrung.Text = txtDaySoTrung.Text + txtSoQuay.Text;
        }

        private void txtDaySoTrung_TextChanged(object sender, EventArgs e)
        {
            if (txtDaySoTrung.Text.Length == 6)
            {
                btnQuaySo.Enabled = false;
                if (txtDaySoNhap.Text == txtDaySoTrung.Text)
                {
                    lbKetQua.Text = "Trúng việt lót rồi bạn ạ !";
                }
                else
                {
                    lbKetQua.Text = "Trúng gió rồi bạn ạ !";
                }
            }            
        }

        private void btnResetKq_Click(object sender, EventArgs e)
        {
            txtDaySoNhap.Text = "";
            txtDaySoTrung.Text = "";
            txtSoQuay.Text = "";
            lbKetQua.Text = "KẾT QUẢ";
            txtDaySoNhap.Enabled = true;
            btnQuaySo.Enabled = false;
        }
    }
}
