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
    public partial class frmBai1_ : Form
    {
        public frmBai1_()
        {
            InitializeComponent();
        }

        private void frmBai1__Load(object sender, EventArgs e)
        {
            HangHoa hh= new HangHoa();
            hh.MaHang = "HH001";
            hh.TenHang = "Chuột";
            hh.DVT = "Cái";
            hh.SoLuong = 4;
            hh.DonGia = 200000000;
            lblThongBao.Text = hh.HienThi();
        }
    }
}
