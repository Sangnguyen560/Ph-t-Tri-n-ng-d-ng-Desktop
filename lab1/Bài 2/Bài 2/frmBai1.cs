using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_2
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void rbX_CheckedChanged(object sender, EventArgs e)
        {
            tbDongia.Text = "22000";
        }

        private void rbDo_CheckedChanged(object sender, EventArgs e)
        {
            tbDongia.Text = "21000";
        }

        private void rbtrang_CheckedChanged(object sender, EventArgs e)
        {
            tbDongia.Text = "20000";
        }

        private void BTT_Click(object sender, EventArgs e)
        {
            int sotien = int.Parse(tbDongia.Text) * int.Parse(tbSoluong.Text);
            ltttt.Text = sotien.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
