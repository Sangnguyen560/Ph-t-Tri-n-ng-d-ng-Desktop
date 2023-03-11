namespace _2113018_Bài_Lý_Thuyết_2
{
    partial class Menu
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
            this.btnImagList = new System.Windows.Forms.Button();
            this.txtContextMenu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPanel = new System.Windows.Forms.Button();
            this.txtGroupbox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnImagList
            // 
            this.btnImagList.Location = new System.Drawing.Point(428, 172);
            this.btnImagList.Name = "btnImagList";
            this.btnImagList.Size = new System.Drawing.Size(181, 36);
            this.btnImagList.TabIndex = 1;
            this.btnImagList.Text = "Demo ImageList";
            this.btnImagList.UseVisualStyleBackColor = true;
            this.btnImagList.Click += new System.EventHandler(this.btnImagList_Click_1);
            // 
            // txtContextMenu
            // 
            this.txtContextMenu.Location = new System.Drawing.Point(428, 108);
            this.txtContextMenu.Name = "txtContextMenu";
            this.txtContextMenu.Size = new System.Drawing.Size(181, 36);
            this.txtContextMenu.TabIndex = 2;
            this.txtContextMenu.Text = "Demo ContextMenu";
            this.txtContextMenu.UseVisualStyleBackColor = true;
            this.txtContextMenu.Click += new System.EventHandler(this.txtContextMenu_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(191, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Demo StatusStrip";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Demo Menustrip";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnPanel
            // 
            this.btnPanel.Location = new System.Drawing.Point(191, 172);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(181, 36);
            this.btnPanel.TabIndex = 5;
            this.btnPanel.Text = "Demo Panel";
            this.btnPanel.UseVisualStyleBackColor = true;
            this.btnPanel.Click += new System.EventHandler(this.btnPanel_Click_1);
            // 
            // txtGroupbox
            // 
            this.txtGroupbox.Location = new System.Drawing.Point(191, 108);
            this.txtGroupbox.Name = "txtGroupbox";
            this.txtGroupbox.Size = new System.Drawing.Size(181, 36);
            this.txtGroupbox.TabIndex = 6;
            this.txtGroupbox.Text = "Demo Groupbox";
            this.txtGroupbox.UseVisualStyleBackColor = true;
            this.txtGroupbox.Click += new System.EventHandler(this.txtGroupbox_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImagList);
            this.Controls.Add(this.txtContextMenu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPanel);
            this.Controls.Add(this.txtGroupbox);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImagList;
        private System.Windows.Forms.Button txtContextMenu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPanel;
        private System.Windows.Forms.Button txtGroupbox;
    }
}

