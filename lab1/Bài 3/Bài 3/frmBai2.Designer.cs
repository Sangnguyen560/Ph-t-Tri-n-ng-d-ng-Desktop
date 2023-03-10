namespace Bài_3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBtenhang = new System.Windows.Forms.ComboBox();
            this.TBDonGia = new System.Windows.Forms.TextBox();
            this.TBSoLuong = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbchuyenkhoan = new System.Windows.Forms.RadioButton();
            this.rbTienmat = new System.Windows.Forms.RadioButton();
            this.BthanhToan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lSotien = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // CBtenhang
            // 
            this.CBtenhang.FormattingEnabled = true;
            this.CBtenhang.Items.AddRange(new object[] {
            "Chuột",
            "Máy in",
            "Bàn phím"});
            this.CBtenhang.Location = new System.Drawing.Point(183, 50);
            this.CBtenhang.Name = "CBtenhang";
            this.CBtenhang.Size = new System.Drawing.Size(201, 24);
            this.CBtenhang.TabIndex = 3;
            this.CBtenhang.SelectedIndexChanged += new System.EventHandler(this.CBtenhang_SelectedIndexChanged);
            // 
            // TBDonGia
            // 
            this.TBDonGia.Location = new System.Drawing.Point(184, 104);
            this.TBDonGia.Name = "TBDonGia";
            this.TBDonGia.Size = new System.Drawing.Size(199, 22);
            this.TBDonGia.TabIndex = 4;
            // 
            // TBSoLuong
            // 
            this.TBSoLuong.Location = new System.Drawing.Point(183, 151);
            this.TBSoLuong.Name = "TBSoLuong";
            this.TBSoLuong.Size = new System.Drawing.Size(199, 22);
            this.TBSoLuong.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTienmat);
            this.groupBox1.Controls.Add(this.rbchuyenkhoan);
            this.groupBox1.Location = new System.Drawing.Point(127, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 111);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hình thức thanh toán";
            // 
            // rbchuyenkhoan
            // 
            this.rbchuyenkhoan.AutoSize = true;
            this.rbchuyenkhoan.Location = new System.Drawing.Point(25, 40);
            this.rbchuyenkhoan.Name = "rbchuyenkhoan";
            this.rbchuyenkhoan.Size = new System.Drawing.Size(114, 20);
            this.rbchuyenkhoan.TabIndex = 0;
            this.rbchuyenkhoan.Text = "Chuyển Khoản";
            this.rbchuyenkhoan.UseVisualStyleBackColor = true;
            // 
            // rbTienmat
            // 
            this.rbTienmat.AutoSize = true;
            this.rbTienmat.Checked = true;
            this.rbTienmat.Location = new System.Drawing.Point(25, 80);
            this.rbTienmat.Name = "rbTienmat";
            this.rbTienmat.Size = new System.Drawing.Size(80, 20);
            this.rbTienmat.TabIndex = 1;
            this.rbTienmat.TabStop = true;
            this.rbTienmat.Text = "Tiền mặt";
            this.rbTienmat.UseVisualStyleBackColor = true;
            // 
            // BthanhToan
            // 
            this.BthanhToan.Location = new System.Drawing.Point(313, 325);
            this.BthanhToan.Name = "BthanhToan";
            this.BthanhToan.Size = new System.Drawing.Size(109, 27);
            this.BthanhToan.TabIndex = 7;
            this.BthanhToan.Text = "Thanh Toán";
            this.BthanhToan.UseVisualStyleBackColor = true;
            this.BthanhToan.Click += new System.EventHandler(this.BthanhToan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số Tiền Thanh Toán:";
            // 
            // lSotien
            // 
            this.lSotien.AutoSize = true;
            this.lSotien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSotien.Location = new System.Drawing.Point(284, 394);
            this.lSotien.Name = "lSotien";
            this.lSotien.Size = new System.Drawing.Size(13, 20);
            this.lSotien.TabIndex = 9;
            this.lSotien.Text = ".";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 450);
            this.Controls.Add(this.lSotien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BthanhToan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TBSoLuong);
            this.Controls.Add(this.TBDonGia);
            this.Controls.Add(this.CBtenhang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai2";
            this.Text = "Bai2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBtenhang;
        private System.Windows.Forms.TextBox TBDonGia;
        private System.Windows.Forms.TextBox TBSoLuong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTienmat;
        private System.Windows.Forms.RadioButton rbchuyenkhoan;
        private System.Windows.Forms.Button BthanhToan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lSotien;
    }
}