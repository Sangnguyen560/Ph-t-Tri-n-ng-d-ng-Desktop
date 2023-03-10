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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tongtien_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bchonhang_Click(object sender, EventArgs e)
        {
            var item = LB1.SelectedItem;
            LB2.Items.Add(item);
        }

        private void bbohang_Click(object sender, EventArgs e)
        {
            LB2.Items.Remove(LB2.SelectedItem);

        }

        private void Btinhtien_Click(object sender, EventArgs e)
        {
            int sotien = 0;
            foreach(string hang in LB2.Items)
                switch(hang)
                {
                    case "Chuột":
                        sotien+=100000;
                        break;
                    case "ban phím":
                        sotien += 150000;
                        break;
                    case "Máy in":
                        sotien += 2000000;
                        break;
                    case "USB kingmax":
                        sotien += 200000;
                        break;
                }
            tongtien.Text = sotien + "Đồng";
        }
    }
}
