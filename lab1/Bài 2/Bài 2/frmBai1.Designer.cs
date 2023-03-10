namespace Bài_2
{
    partial class frmBai1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBai1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtrang = new System.Windows.Forms.RadioButton();
            this.rbDo = new System.Windows.Forms.RadioButton();
            this.rbX = new System.Windows.Forms.RadioButton();
            this.lDG = new System.Windows.Forms.Label();
            this.LSL = new System.Windows.Forms.Label();
            this.tbDongia = new System.Windows.Forms.TextBox();
            this.tbSoluong = new System.Windows.Forms.TextBox();
            this.BTT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ltttt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtrang);
            this.groupBox1.Controls.Add(this.rbDo);
            this.groupBox1.Controls.Add(this.rbX);
            this.groupBox1.Location = new System.Drawing.Point(551, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn màu xe";
            // 
            // rbtrang
            // 
            this.rbtrang.AutoSize = true;
            this.rbtrang.Location = new System.Drawing.Point(48, 150);
            this.rbtrang.Name = "rbtrang";
            this.rbtrang.Size = new System.Drawing.Size(64, 20);
            this.rbtrang.TabIndex = 2;
            this.rbtrang.TabStop = true;
            this.rbtrang.Text = "Trắng";
            this.rbtrang.UseVisualStyleBackColor = true;
            this.rbtrang.CheckedChanged += new System.EventHandler(this.rbtrang_CheckedChanged);
            // 
            // rbDo
            // 
            this.rbDo.AutoSize = true;
            this.rbDo.Location = new System.Drawing.Point(48, 108);
            this.rbDo.Name = "rbDo";
            this.rbDo.Size = new System.Drawing.Size(45, 20);
            this.rbDo.TabIndex = 1;
            this.rbDo.TabStop = true;
            this.rbDo.Text = "Đỏ";
            this.rbDo.UseVisualStyleBackColor = true;
            this.rbDo.CheckedChanged += new System.EventHandler(this.rbDo_CheckedChanged);
            // 
            // rbX
            // 
            this.rbX.AutoSize = true;
            this.rbX.Location = new System.Drawing.Point(48, 63);
            this.rbX.Name = "rbX";
            this.rbX.Size = new System.Drawing.Size(58, 20);
            this.rbX.TabIndex = 0;
            this.rbX.TabStop = true;
            this.rbX.Text = "Xanh";
            this.rbX.UseVisualStyleBackColor = true;
            this.rbX.CheckedChanged += new System.EventHandler(this.rbX_CheckedChanged);
            // 
            // lDG
            // 
            this.lDG.AutoSize = true;
            this.lDG.Location = new System.Drawing.Point(543, 318);
            this.lDG.Name = "lDG";
            this.lDG.Size = new System.Drawing.Size(53, 16);
            this.lDG.TabIndex = 1;
            this.lDG.Text = "Đơn giá";
            // 
            // LSL
            // 
            this.LSL.AutoSize = true;
            this.LSL.Location = new System.Drawing.Point(543, 357);
            this.LSL.Name = "LSL";
            this.LSL.Size = new System.Drawing.Size(60, 16);
            this.LSL.TabIndex = 3;
            this.LSL.Text = "Số lượng";
            // 
            // tbDongia
            // 
            this.tbDongia.Location = new System.Drawing.Point(615, 315);
            this.tbDongia.Name = "tbDongia";
            this.tbDongia.Size = new System.Drawing.Size(134, 22);
            this.tbDongia.TabIndex = 4;
            // 
            // tbSoluong
            // 
            this.tbSoluong.Location = new System.Drawing.Point(615, 354);
            this.tbSoluong.Name = "tbSoluong";
            this.tbSoluong.Size = new System.Drawing.Size(86, 22);
            this.tbSoluong.TabIndex = 5;
            // 
            // BTT
            // 
            this.BTT.Location = new System.Drawing.Point(615, 397);
            this.BTT.Name = "BTT";
            this.BTT.Size = new System.Drawing.Size(84, 29);
            this.BTT.TabIndex = 6;
            this.BTT.Text = "Tính tiền";
            this.BTT.UseVisualStyleBackColor = true;
            this.BTT.Click += new System.EventHandler(this.BTT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(466, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "TỔNG TIỀN THANH TOÁN: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(755, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "$";
            // 
            // ltttt
            // 
            this.ltttt.AutoSize = true;
            this.ltttt.Location = new System.Drawing.Point(663, 452);
            this.ltttt.Name = "ltttt";
            this.ltttt.Size = new System.Drawing.Size(14, 16);
            this.ltttt.TabIndex = 10;
            this.ltttt.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(755, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "$";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Bài_2.Properties.Resources.hinh_nen_xe_oto_dep_7;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(446, 315);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 523);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ltttt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTT);
            this.Controls.Add(this.tbSoluong);
            this.Controls.Add(this.tbDongia);
            this.Controls.Add(this.LSL);
            this.Controls.Add(this.lDG);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtrang;
        private System.Windows.Forms.RadioButton rbDo;
        private System.Windows.Forms.RadioButton rbX;
        private System.Windows.Forms.Label lDG;
        private System.Windows.Forms.Label LSL;
        private System.Windows.Forms.TextBox tbDongia;
        private System.Windows.Forms.TextBox tbSoluong;
        private System.Windows.Forms.Button BTT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ltttt;
        private System.Windows.Forms.Label label4;
    }
}

