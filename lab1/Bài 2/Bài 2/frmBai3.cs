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
    public partial class frmBai3 : Form
    {
        List<string> list = new List<string>();
        public frmBai3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void BTUM_Click(object sender, EventArgs e)
        {
            var tu = TBTM.Text;
            var nghia = TBN.Text;
            list.Add(nghia);
            list.Add(tu);
            TBTM.Focus();
            TBN.Text = "";
            TBTM.Text = "";
            LB1.SelectedIndex = LB1.Items.Count - 1;
            TBNcuaTu.Text = nghia;
        }

        private void LB1_SelectedIndexChanged(object sender, EventArgs e)
        {

            var stt = LB1.SelectedIndex;

            TBNcuaTu.Text = list[stt];
        }
    }
}
