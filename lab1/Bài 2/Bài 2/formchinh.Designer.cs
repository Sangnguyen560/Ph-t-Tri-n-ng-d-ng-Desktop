namespace Bài_2
{
    partial class formchinh
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BLC = new System.Windows.Forms.ToolStripMenuItem();
            this.bai1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bai2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bai3 = new System.Windows.Forms.ToolStripMenuItem();
            this.bài4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BLC});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // BLC
            // 
            this.BLC.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bai1,
            this.bai2,
            this.bai3,
            this.bài4ToolStripMenuItem});
            this.BLC.Name = "BLC";
            this.BLC.Size = new System.Drawing.Size(191, 24);
            this.BLC.Text = "Nguyễn Phan Thanh Sang";
            this.BLC.Click += new System.EventHandler(this.BLC_Click);
            // 
            // bai1
            // 
            this.bai1.Image = global::Bài_2.Properties.Resources._20220702_071114;
            this.bai1.Name = "bai1";
            this.bai1.Size = new System.Drawing.Size(125, 26);
            this.bai1.Text = "Bài 1";
            this.bai1.Click += new System.EventHandler(this.bai1_Click);
            // 
            // bai2
            // 
            this.bai2.Image = global::Bài_2.Properties.Resources._105573490_p0;
            this.bai2.Name = "bai2";
            this.bai2.Size = new System.Drawing.Size(125, 26);
            this.bai2.Text = "Bài 2";
            this.bai2.Click += new System.EventHandler(this.bai2_Click);
            // 
            // bai3
            // 
            this.bai3.Image = global::Bài_2.Properties.Resources._105558294_p0;
            this.bai3.Name = "bai3";
            this.bai3.Size = new System.Drawing.Size(125, 26);
            this.bai3.Text = "bài 3";
            this.bai3.Click += new System.EventHandler(this.bai3_Click);
            // 
            // bài4ToolStripMenuItem
            // 
            this.bài4ToolStripMenuItem.Image = global::Bài_2.Properties.Resources._312832;
            this.bài4ToolStripMenuItem.Name = "bài4ToolStripMenuItem";
            this.bài4ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bài4ToolStripMenuItem.Text = "Bài 4";
            this.bài4ToolStripMenuItem.Click += new System.EventHandler(this.bài4ToolStripMenuItem_Click);
            // 
            // formchinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formchinh";
            this.Text = "Chương trình chính";
            this.Load += new System.EventHandler(this.formchinh_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BLC;
        private System.Windows.Forms.ToolStripMenuItem bai1;
        private System.Windows.Forms.ToolStripMenuItem bai2;
        private System.Windows.Forms.ToolStripMenuItem bai3;
        private System.Windows.Forms.ToolStripMenuItem bài4ToolStripMenuItem;
    }
}