namespace Bài_3
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbsoa = new System.Windows.Forms.TextBox();
            this.tbsob = new System.Windows.Forms.TextBox();
            this.tbson = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtongab = new System.Windows.Forms.RadioButton();
            this.rbtongdayn = new System.Windows.Forms.RadioButton();
            this.Bxemkq = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lKetQua = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "a=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "n=";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "b=";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbsoa
            // 
            this.tbsoa.Location = new System.Drawing.Point(140, 45);
            this.tbsoa.Name = "tbsoa";
            this.tbsoa.Size = new System.Drawing.Size(159, 22);
            this.tbsoa.TabIndex = 3;
            this.tbsoa.Tag = "";
            this.tbsoa.Text = "0";
            // 
            // tbsob
            // 
            this.tbsob.Location = new System.Drawing.Point(140, 85);
            this.tbsob.Name = "tbsob";
            this.tbsob.Size = new System.Drawing.Size(159, 22);
            this.tbsob.TabIndex = 4;
            this.tbsob.Text = "0";
            // 
            // tbson
            // 
            this.tbson.Location = new System.Drawing.Point(140, 130);
            this.tbson.Name = "tbson";
            this.tbson.Size = new System.Drawing.Size(159, 22);
            this.tbson.TabIndex = 5;
            this.tbson.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtongdayn);
            this.groupBox1.Controls.Add(this.rbtongab);
            this.groupBox1.Location = new System.Drawing.Point(102, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 120);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn phép toán";
            // 
            // rbtongab
            // 
            this.rbtongab.AutoSize = true;
            this.rbtongab.Checked = true;
            this.rbtongab.Location = new System.Drawing.Point(37, 35);
            this.rbtongab.Name = "rbtongab";
            this.rbtongab.Size = new System.Drawing.Size(107, 20);
            this.rbtongab.TabIndex = 0;
            this.rbtongab.TabStop = true;
            this.rbtongab.Text = "Tổng của a,b";
            this.rbtongab.UseVisualStyleBackColor = true;
            // 
            // rbtongdayn
            // 
            this.rbtongdayn.AutoSize = true;
            this.rbtongdayn.Location = new System.Drawing.Point(34, 73);
            this.rbtongdayn.Name = "rbtongdayn";
            this.rbtongdayn.Size = new System.Drawing.Size(151, 20);
            this.rbtongdayn.TabIndex = 1;
            this.rbtongdayn.Text = "Tổng của dãy từ 1 - n";
            this.rbtongdayn.UseVisualStyleBackColor = true;
            // 
            // Bxemkq
            // 
            this.Bxemkq.Location = new System.Drawing.Point(167, 324);
            this.Bxemkq.Name = "Bxemkq";
            this.Bxemkq.Size = new System.Drawing.Size(120, 29);
            this.Bxemkq.TabIndex = 7;
            this.Bxemkq.Text = "Xem Kết quả";
            this.Bxemkq.UseVisualStyleBackColor = true;
            this.Bxemkq.Click += new System.EventHandler(this.Bxemkq_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "KẾT QUẢ LÀ:";
            // 
            // lKetQua
            // 
            this.lKetQua.AutoSize = true;
            this.lKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lKetQua.Location = new System.Drawing.Point(213, 399);
            this.lKetQua.Name = "lKetQua";
            this.lKetQua.Size = new System.Drawing.Size(13, 20);
            this.lKetQua.TabIndex = 9;
            this.lKetQua.Text = ".";
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 594);
            this.Controls.Add(this.lKetQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Bxemkq);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbson);
            this.Controls.Add(this.tbsob);
            this.Controls.Add(this.tbsoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai3";
            this.Text = "Bài 3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbsoa;
        private System.Windows.Forms.TextBox tbsob;
        private System.Windows.Forms.TextBox tbson;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtongdayn;
        private System.Windows.Forms.RadioButton rbtongab;
        private System.Windows.Forms.Button Bxemkq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lKetQua;
    }
}