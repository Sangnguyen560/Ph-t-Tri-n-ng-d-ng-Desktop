namespace Bài_tập_2
{
    partial class frmChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinh));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbbai1 = new System.Windows.Forms.ToolStripButton();
            this.tsbBai2 = new System.Windows.Forms.ToolStripButton();
            this.tsbBai3 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbbai1,
            this.tsbBai2,
            this.tsbBai3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbbai1
            // 
            this.tsbbai1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbbai1.Image = ((System.Drawing.Image)(resources.GetObject("tsbbai1.Image")));
            this.tsbbai1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbbai1.Name = "tsbbai1";
            this.tsbbai1.Size = new System.Drawing.Size(29, 24);
            this.tsbbai1.Text = "Bài 1";
            // 
            // tsbBai2
            // 
            this.tsbBai2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBai2.Image = ((System.Drawing.Image)(resources.GetObject("tsbBai2.Image")));
            this.tsbBai2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBai2.Name = "tsbBai2";
            this.tsbBai2.Size = new System.Drawing.Size(29, 24);
            this.tsbBai2.Text = "Bài 2";
            // 
            // tsbBai3
            // 
            this.tsbBai3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBai3.Image = ((System.Drawing.Image)(resources.GetObject("tsbBai3.Image")));
            this.tsbBai3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBai3.Name = "tsbBai3";
            this.tsbBai3.Size = new System.Drawing.Size(29, 24);
            this.tsbBai3.Text = "Bài 3";
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmChinh";
            this.Text = "frmChinh";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbbai1;
        private System.Windows.Forms.ToolStripButton tsbBai2;
        private System.Windows.Forms.ToolStripButton tsbBai3;
    }
}