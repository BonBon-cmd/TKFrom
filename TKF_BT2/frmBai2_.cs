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
    public partial class frmBai2_ : Form
    {
        public frmBai2_()
        {
            InitializeComponent();
        }
        private void cbTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stt = cbTenHang.SelectedIndex;
            switch (stt) 
            {
                case 0:
                    txtDonGia.Text = "100000";
                    break;
                case 1:
                    txtDonGia.Text = "150000";
                    break;
                case 2:
                    txtDonGia.Text = "2000000";
                    break;
            }
        }

        private void lblSoLuong_Click(object sender, EventArgs e)
        {

        }

        private void btnTinhTien_Click_1(object sender, EventArgs e)
        {
            int donGia = int.Parse(txtDonGia.Text);
            int soLuong = int.Parse(txtSoLuong.Text);
            if (rdCK.Checked)
            {
                double tongTien = donGia * soLuong *0.95;
                lblSoTien.Text = tongTien.ToString();
            }
            else
            {
                double tongTien = donGia * soLuong;
                lblSoTien.Text = tongTien.ToString();
            }
        }
    }
}
