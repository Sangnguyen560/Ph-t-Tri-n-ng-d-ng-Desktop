namespace Bài_2
{
    partial class frmBai3
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
            this.TBTM = new System.Windows.Forms.TextBox();
            this.TBN = new System.Windows.Forms.TextBox();
            this.BTUM = new System.Windows.Forms.Button();
            this.LB1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBNcuaTu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nghĩa của từ";
            // 
            // TBTM
            // 
            this.TBTM.Location = new System.Drawing.Point(176, 58);
            this.TBTM.Name = "TBTM";
            this.TBTM.Size = new System.Drawing.Size(136, 22);
            this.TBTM.TabIndex = 0;
            // 
            // TBN
            // 
            this.TBN.Location = new System.Drawing.Point(176, 99);
            this.TBN.Name = "TBN";
            this.TBN.Size = new System.Drawing.Size(212, 22);
            this.TBN.TabIndex = 1;
            // 
            // BTUM
            // 
            this.BTUM.Location = new System.Drawing.Point(176, 140);
            this.BTUM.Name = "BTUM";
            this.BTUM.Size = new System.Drawing.Size(108, 27);
            this.BTUM.TabIndex = 2;
            this.BTUM.Text = "Thêm từ mới";
            this.BTUM.UseVisualStyleBackColor = true;
            this.BTUM.Click += new System.EventHandler(this.BTUM_Click);
            // 
            // LB1
            // 
            this.LB1.FormattingEnabled = true;
            this.LB1.ItemHeight = 16;
            this.LB1.Location = new System.Drawing.Point(103, 210);
            this.LB1.Name = "LB1";
            this.LB1.Size = new System.Drawing.Size(305, 164);
            this.LB1.TabIndex = 5;
            this.LB1.SelectedIndexChanged += new System.EventHandler(this.LB1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "DANH SÁCH TỪ MỚI";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TBNcuaTu
            // 
            this.TBNcuaTu.Location = new System.Drawing.Point(453, 210);
            this.TBNcuaTu.Multiline = true;
            this.TBNcuaTu.Name = "TBNcuaTu";
            this.TBNcuaTu.Size = new System.Drawing.Size(258, 164);
            this.TBNcuaTu.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(519, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "NGHĨA CỦA TỪ";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 467);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBNcuaTu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LB1);
            this.Controls.Add(this.BTUM);
            this.Controls.Add(this.TBN);
            this.Controls.Add(this.TBTM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBTM;
        private System.Windows.Forms.TextBox TBN;
        private System.Windows.Forms.Button BTUM;
        private System.Windows.Forms.ListBox LB1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBNcuaTu;
        private System.Windows.Forms.Label label4;
    }
}