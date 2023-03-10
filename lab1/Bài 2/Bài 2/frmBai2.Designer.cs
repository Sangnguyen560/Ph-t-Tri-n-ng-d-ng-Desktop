namespace Bài_2
{
    partial class frmBai2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LB1 = new System.Windows.Forms.ListBox();
            this.bchonhang = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bbohang = new System.Windows.Forms.Button();
            this.LB2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tongtien = new System.Windows.Forms.Label();
            this.Btinhtien = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bchonhang);
            this.panel1.Controls.Add(this.LB1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(30, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 307);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách cửa hàng";
            // 
            // LB1
            // 
            this.LB1.FormattingEnabled = true;
            this.LB1.ItemHeight = 16;
            this.LB1.Items.AddRange(new object[] {
            "Chuột",
            "Bàn phím",
            "Máy in ",
            "USB kingmax"});
            this.LB1.Location = new System.Drawing.Point(38, 85);
            this.LB1.Name = "LB1";
            this.LB1.Size = new System.Drawing.Size(189, 132);
            this.LB1.TabIndex = 1;
            this.LB1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // bchonhang
            // 
            this.bchonhang.Location = new System.Drawing.Point(264, 85);
            this.bchonhang.Name = "bchonhang";
            this.bchonhang.Size = new System.Drawing.Size(112, 24);
            this.bchonhang.TabIndex = 2;
            this.bchonhang.Text = "Chọn hàng >";
            this.bchonhang.UseVisualStyleBackColor = true;
            this.bchonhang.Click += new System.EventHandler(this.bchonhang_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Btinhtien);
            this.panel2.Controls.Add(this.tongtien);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.bbohang);
            this.panel2.Controls.Add(this.LB2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(467, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(431, 307);
            this.panel2.TabIndex = 1;
            // 
            // bbohang
            // 
            this.bbohang.Location = new System.Drawing.Point(37, 85);
            this.bbohang.Name = "bbohang";
            this.bbohang.Size = new System.Drawing.Size(112, 24);
            this.bbohang.TabIndex = 2;
            this.bbohang.Text = "< Bỏ hàng";
            this.bbohang.UseVisualStyleBackColor = true;
            this.bbohang.Click += new System.EventHandler(this.bbohang_Click);
            // 
            // LB2
            // 
            this.LB2.FormattingEnabled = true;
            this.LB2.ItemHeight = 16;
            this.LB2.Location = new System.Drawing.Point(199, 85);
            this.LB2.Name = "LB2";
            this.LB2.Size = new System.Drawing.Size(189, 132);
            this.LB2.TabIndex = 1;
            this.LB2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Các mặt hàng khách mua";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "BÁN HÀNG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "TỔNG TIỀN THANH TOÁN:";
            // 
            // tongtien
            // 
            this.tongtien.AutoSize = true;
            this.tongtien.Location = new System.Drawing.Point(241, 249);
            this.tongtien.Name = "tongtien";
            this.tongtien.Size = new System.Drawing.Size(14, 16);
            this.tongtien.TabIndex = 4;
            this.tongtien.Text = "0";
            this.tongtien.Click += new System.EventHandler(this.tongtien_Click);
            // 
            // Btinhtien
            // 
            this.Btinhtien.Location = new System.Drawing.Point(52, 208);
            this.Btinhtien.Name = "Btinhtien";
            this.Btinhtien.Size = new System.Drawing.Size(89, 29);
            this.Btinhtien.TabIndex = 5;
            this.Btinhtien.Text = "Tính tiền";
            this.Btinhtien.UseVisualStyleBackColor = true;
            this.Btinhtien.Click += new System.EventHandler(this.Btinhtien_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox LB1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bchonhang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bbohang;
        private System.Windows.Forms.ListBox LB2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tongtien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btinhtien;
    }
}