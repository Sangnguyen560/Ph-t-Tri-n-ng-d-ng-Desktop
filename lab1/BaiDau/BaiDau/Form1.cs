using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiDau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TBSCH.Text = TBox.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BN_Click(object sender, EventArgs e)
        {
            var tenDN = TBox.Text;
            MessageBox.Show($"Xin Chào bạn {tenDN} .Rất vui được gặp bạn"," Thông điệp chào mừng");

        }

        private void BSaochep_Click(object sender, EventArgs e)
        {
            TBSCH.Text = TBox.Text;
        }

        private void TBSCH_TextChanged(object sender, EventArgs e)
        {
            TBSCH.Text = TBox.Text;
        }
    }
}
