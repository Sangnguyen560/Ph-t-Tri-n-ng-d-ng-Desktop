namespace BaiDau
{
    partial class Form1
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
            this.TBox = new System.Windows.Forms.TextBox();
            this.BN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BSaochep = new System.Windows.Forms.Button();
            this.TBSCH = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hãy Nhập Tên Bạn:";
            // 
            // TBox
            // 
            this.TBox.Location = new System.Drawing.Point(266, 88);
            this.TBox.Name = "TBox";
            this.TBox.Size = new System.Drawing.Size(273, 22);
            this.TBox.TabIndex = 1;
            this.TBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BN
            // 
            this.BN.Location = new System.Drawing.Point(305, 155);
            this.BN.Name = "BN";
            this.BN.Size = new System.Drawing.Size(84, 35);
            this.BN.TabIndex = 2;
            this.BN.Text = "Xử Lý";
            this.BN.UseVisualStyleBackColor = true;
            this.BN.Click += new System.EventHandler(this.BN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bạn Đã Nhập:";
            // 
            // BSaochep
            // 
            this.BSaochep.Location = new System.Drawing.Point(420, 156);
            this.BSaochep.Name = "BSaochep";
            this.BSaochep.Size = new System.Drawing.Size(83, 34);
            this.BSaochep.TabIndex = 4;
            this.BSaochep.Text = "Sao Chép";
            this.BSaochep.UseVisualStyleBackColor = true;
            this.BSaochep.Click += new System.EventHandler(this.BSaochep_Click);
            // 
            // TBSCH
            // 
            this.TBSCH.Location = new System.Drawing.Point(266, 229);
            this.TBSCH.Name = "TBSCH";
            this.TBSCH.ReadOnly = true;
            this.TBSCH.Size = new System.Drawing.Size(273, 22);
            this.TBSCH.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TBSCH);
            this.Controls.Add(this.BSaochep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BN);
            this.Controls.Add(this.TBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Chương Trình Đầu Tiên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBox;
        private System.Windows.Forms.Button BN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BSaochep;
        private System.Windows.Forms.TextBox TBSCH;
    }
}

