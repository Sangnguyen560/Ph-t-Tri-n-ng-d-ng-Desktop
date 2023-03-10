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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Bxemkq_Click(object sender, EventArgs e)
        {

            int a =int.Parse(tbsoa.Text);
            int b =int.Parse(tbsob.Text);
            int n = int.Parse(tbson.Text);
            int kq=0;

            if (rbtongab.Checked)
                TinhToan.Conghaiso(a, b, ref kq);
            else
                kq = TinhToan.Tongdayso(n);

            lKetQua.Text=kq.ToString();
        }
    }
}
