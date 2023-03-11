namespace _2113018_Bài_Lý_Thuyết_2
{
    partial class frmContextMenu
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
            this.lbNgoaiNgu = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbNgoaiNgu
            // 
            this.lbNgoaiNgu.FormattingEnabled = true;
            this.lbNgoaiNgu.ItemHeight = 16;
            this.lbNgoaiNgu.Items.AddRange(new object[] {
            "Tiếng Anh",
            "Tiếng Pháp",
            "Tiếng Nhật",
            "Tiếng Hàn",
            "Tiếng Việt",
            "Tiếng Đức",
            "Tiếng Nga"});
            this.lbNgoaiNgu.Location = new System.Drawing.Point(73, 57);
            this.lbNgoaiNgu.Name = "lbNgoaiNgu";
            this.lbNgoaiNgu.Size = new System.Drawing.Size(150, 100);
            this.lbNgoaiNgu.TabIndex = 1;
            // 
            // frmContextMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbNgoaiNgu);
            this.Name = "frmContextMenu";
            this.Text = "frmContextMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbNgoaiNgu;
    }
}