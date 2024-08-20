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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }
        
        List<string> list = new List<string>();
        private void btnThemTu_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txtTuMoi.Text);
            list.Add(txtNghia.Text);
            txtTuMoi.Focus();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtHienNghia.Text = list[listBox1.SelectedIndex];
        }
    }
}
