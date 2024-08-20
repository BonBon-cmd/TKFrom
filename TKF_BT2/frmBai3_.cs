using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TKF_BT2
{
    public partial class frmBai3_ : Form
    {
        public frmBai3_()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSoA.Text);
            int b = int.Parse(txtSoB.Text);
            int n = int.Parse(txtSoN.Text);
            int kq = 0;
            if (rdTongAB.Checked)
                kq = TinhToan.CongHaiSo(a, b);  
            else
                kq = TinhToan.TongDaySo(n);
            lblKetQua.Text = kq.ToString();   

        }
    }
}
