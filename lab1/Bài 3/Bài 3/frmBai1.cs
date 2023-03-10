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
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            HangHoa hh = new HangHoa();
            hh.MatHang = "H001";
            hh.TenHang = " Chuột";
            hh.DVT = "Cái";
            hh.SoLuong = 4;
            hh.DonGia = 200000;
            lThongbao.Text = hh.Xuat();
        }
    }
}
