namespace Bài_2
{
    partial class frmBai4
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSo = new System.Windows.Forms.TextBox();
            this.Btim = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LKQ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(70, 86);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(251, 276);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập số cần tìm:";
            // 
            // tbSo
            // 
            this.tbSo.Location = new System.Drawing.Point(502, 116);
            this.tbSo.Name = "tbSo";
            this.tbSo.Size = new System.Drawing.Size(122, 22);
            this.tbSo.TabIndex = 2;
            // 
            // Btim
            // 
            this.Btim.Location = new System.Drawing.Point(526, 177);
            this.Btim.Name = "Btim";
            this.Btim.Size = new System.Drawing.Size(83, 27);
            this.Btim.TabIndex = 3;
            this.Btim.Text = "Tìm số";
            this.Btim.UseVisualStyleBackColor = true;
            this.Btim.Click += new System.EventHandler(this.Btim_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(391, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "KẾT QUẢ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LKQ
            // 
            this.LKQ.AutoSize = true;
            this.LKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LKQ.ForeColor = System.Drawing.Color.Crimson;
            this.LKQ.Location = new System.Drawing.Point(520, 265);
            this.LKQ.Name = "LKQ";
            this.LKQ.Size = new System.Drawing.Size(14, 20);
            this.LKQ.TabIndex = 5;
            this.LKQ.Text = ".";
            // 
            // frmBai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LKQ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btim);
            this.Controls.Add(this.tbSo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "frmBai4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.frmBai4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSo;
        private System.Windows.Forms.Button Btim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LKQ;
    }
}