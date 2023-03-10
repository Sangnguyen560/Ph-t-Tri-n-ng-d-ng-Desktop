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
    public partial class formchinh : Form
    {
        public formchinh()
        {
            InitializeComponent();
        }

        private void BLC_Click(object sender, EventArgs e)
        {
            
        }

        private void bai1_Click(object sender, EventArgs e)
        {
            var form = new frmBai1();
            form.ShowDialog();
        }

        private void bai2_Click(object sender, EventArgs e)
        {
            var form = new frmBai2();
            form.ShowDialog();
        }

        private void bai3_Click(object sender, EventArgs e)
        {
            var form = new frmBai3();
            form.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void formchinh_Load(object sender, EventArgs e)
        {

        }

        private void bài4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmBai4();
            form.ShowDialog();
        }
    }
}
