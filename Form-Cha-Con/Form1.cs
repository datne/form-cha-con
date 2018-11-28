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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuTinhTong_Click(object sender, EventArgs e)
        {
            TinhTong t = new TinhTong();            
            t.MdiParent = this;
            if (Application.OpenForms.OfType<TinhTong>().Count() == 0)
            {
                t.Show();
            }           
        }

        private void mnuXoSo_Click(object sender, EventArgs e)
        {
            XoSo x = new XoSo();
            x.MdiParent = this;
            if (Application.OpenForms.OfType<XoSo>().Count() == 0)
            {
                x.Show();
            }
        }
    }
}
