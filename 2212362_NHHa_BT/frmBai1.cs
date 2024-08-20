using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2212362_NHHa_BT
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "20000";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }   

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdXanh_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "22000";
        }

        private void rdDo_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "21000";
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDonGia.Text, out int donGia) && int.TryParse(txtSoLuong.Text, out int soLuong))
            {
                
                int tongTien = donGia * soLuong;
                lblSoTien.Text = tongTien.ToString();
            }
            else
            {
                MessageBox.Show("Đơn giá không hợp lệ!");
            }
        }
    }
}
