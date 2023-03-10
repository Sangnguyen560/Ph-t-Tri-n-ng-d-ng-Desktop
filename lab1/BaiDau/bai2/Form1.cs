using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void rbNam_CheckedChanged(object sender, EventArgs e)
        {
            if(rbNam.Checked)
            MessageBox.Show("Bạn chọn giới tính nam", "Thông báo"); 
        }

        private void rbnu_CheckedChanged(object sender, EventArgs e)
        {
            if(rbnu.Checked)
            MessageBox.Show("Bạn chọn giới tính nữ", "Thông báo");
        }

        private void txthopmau_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btomau_Click(object sender, EventArgs e)
        {
            if (rbdo.Checked)
                txthopmau.BackColor = Color.Red;
            else
                txthopmau.BackColor = Color.Green;
        }
    }
}