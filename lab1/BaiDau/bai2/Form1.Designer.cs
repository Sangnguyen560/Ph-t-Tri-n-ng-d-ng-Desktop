namespace bai2
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.rbnu = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbxanh = new System.Windows.Forms.RadioButton();
            this.rbdo = new System.Windows.Forms.RadioButton();
            this.btomau = new System.Windows.Forms.Button();
            this.txthopmau = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnu);
            this.groupBox1.Controls.Add(this.rbNam);
            this.groupBox1.Location = new System.Drawing.Point(132, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn giới tính";
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(38, 52);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(57, 20);
            this.rbNam.TabIndex = 0;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            this.rbNam.CheckedChanged += new System.EventHandler(this.rbNam_CheckedChanged);
            // 
            // rbnu
            // 
            this.rbnu.AutoSize = true;
            this.rbnu.Location = new System.Drawing.Point(38, 98);
            this.rbnu.Name = "rbnu";
            this.rbnu.Size = new System.Drawing.Size(45, 20);
            this.rbnu.TabIndex = 1;
            this.rbnu.Text = "Nữ";
            this.rbnu.UseVisualStyleBackColor = true;
            this.rbnu.CheckedChanged += new System.EventHandler(this.rbnu_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btomau);
            this.groupBox2.Controls.Add(this.rbxanh);
            this.groupBox2.Controls.Add(this.rbdo);
            this.groupBox2.Location = new System.Drawing.Point(132, 325);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 191);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn màu";
            // 
            // rbxanh
            // 
            this.rbxanh.AutoSize = true;
            this.rbxanh.Location = new System.Drawing.Point(38, 98);
            this.rbxanh.Name = "rbxanh";
            this.rbxanh.Size = new System.Drawing.Size(85, 20);
            this.rbxanh.TabIndex = 1;
            this.rbxanh.Text = "Màu xanh";
            this.rbxanh.UseVisualStyleBackColor = true;
            // 
            // rbdo
            // 
            this.rbdo.AutoSize = true;
            this.rbdo.Location = new System.Drawing.Point(38, 52);
            this.rbdo.Name = "rbdo";
            this.rbdo.Size = new System.Drawing.Size(73, 20);
            this.rbdo.TabIndex = 0;
            this.rbdo.Text = "Màu đỏ";
            this.rbdo.UseVisualStyleBackColor = true;
            // 
            // btomau
            // 
            this.btomau.Location = new System.Drawing.Point(285, 56);
            this.btomau.Name = "btomau";
            this.btomau.Size = new System.Drawing.Size(85, 61);
            this.btomau.TabIndex = 2;
            this.btomau.Text = "Tô màu";
            this.btomau.UseVisualStyleBackColor = true;
            this.btomau.Click += new System.EventHandler(this.btomau_Click);
            // 
            // txthopmau
            // 
            this.txthopmau.Location = new System.Drawing.Point(545, 343);
            this.txthopmau.Multiline = true;
            this.txthopmau.Name = "txthopmau";
            this.txthopmau.ReadOnly = true;
            this.txthopmau.Size = new System.Drawing.Size(207, 173);
            this.txthopmau.TabIndex = 3;
            this.txthopmau.TextChanged += new System.EventHandler(this.txthopmau_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 586);
            this.Controls.Add(this.txthopmau);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Bài tập 2";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btomau;
        private System.Windows.Forms.RadioButton rbxanh;
        private System.Windows.Forms.RadioButton rbdo;
        private System.Windows.Forms.TextBox txthopmau;
    }
}

