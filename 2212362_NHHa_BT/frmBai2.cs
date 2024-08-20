using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212362_NHHa_BT
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
            foreach (var hangHoa in danhSachHangHoa)
            {
                lbMatHang.Items.Add(hangHoa.Key);
            }
        }

        private void btnChonHang_Click(object sender, EventArgs e)
        {
            var item = lbMatHang.SelectedItem;
            lbHangMua.Items.Add(item);
        }

        private void btnBoHang_Click(object sender, EventArgs e)
        {
            var item = lbHangMua.SelectedItem;
            lbHangMua.Items.Remove(item);
        }
        private Dictionary<string, int> danhSachHangHoa = new Dictionary<string, int>()
        {
            {"Chuột", 100000},
            {"Bàn phím", 150000},
            {"Máy in", 2000000},
            {"USB Kingmax", 200000}
        };

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int tongTien = 0;
            foreach (var item in lbHangMua.Items) 
            {
                tongTien += danhSachHangHoa[item.ToString()];
            }
            lblTien.Text = tongTien.ToString();
        }
    }
}
