using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2113018_Bài_Lý_Thuyết_2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
 
        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void txtContextMenu_Click_1(object sender, EventArgs e)
        {
            var form = new frmContextMenu();
            form.ShowDialog();
        }

        private void btnImagList_Click_1(object sender, EventArgs e)
        {
            var form = new frmImagelist();
            form.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var form = new frmStatusStrip();
            form.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var form = new frmMenuStrip();
            form.ShowDialog();
        }

        private void btnPanel_Click_1(object sender, EventArgs e)
        {
            var form = new demoPanel();
            form.ShowDialog();
        }

        private void txtGroupbox_Click(object sender, EventArgs e)
        {
            var form = new frmGroupbox();
            form.ShowDialog();
        }
    }
}
