using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_3
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CBtenhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stt = CBtenhang.SelectedIndex;
            switch(stt)
            {
                case 0:
                    TBDonGia.Text = "100000";
                    break;
                case 1:
                    TBDonGia.Text = "2000000";
                    break;
                case 2:
                    TBDonGia.Text = "150000";
                    break;

            }    
        }

        private void BthanhToan_Click(object sender, EventArgs e)
        {
            int dongia = int.Parse(TBDonGia.Text);
            int soluong = int.Parse(TBSoLuong.Text);
            double ThanhTien = 0;

            if (rbchuyenkhoan.Checked)
                ThanhTien = dongia * soluong - 0.05 * dongia * soluong;
            else ThanhTien = dongia * soluong;
            lSotien.Text = ThanhTien.ToString();
        }
    }
}
