namespace E_commerce_Tool
{
    partial class Form3
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
            pictureBoxBanner = new PictureBox();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            aboutUsToolStripMenuItem = new ToolStripMenuItem();
            loginRegisterToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBanner).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxBanner
            // 
            pictureBoxBanner.Image = Properties.Resources.finn_czCKSIKX0Us_unsplash;
            pictureBoxBanner.Location = new Point(12, 99);
            pictureBoxBanner.Margin = new Padding(3, 2, 3, 2);
            pictureBoxBanner.Name = "pictureBoxBanner";
            pictureBoxBanner.Size = new Size(1697, 533);
            pictureBoxBanner.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBanner.TabIndex = 0;
            pictureBoxBanner.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, aboutUsToolStripMenuItem, loginRegisterToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1739, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(52, 20);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // aboutUsToolStripMenuItem
            // 
            aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            aboutUsToolStripMenuItem.Size = new Size(68, 20);
            aboutUsToolStripMenuItem.Text = "About Us";
            aboutUsToolStripMenuItem.Click += aboutUsToolStripMenuItem_Click_1;
            // 
            // loginRegisterToolStripMenuItem
            // 
            loginRegisterToolStripMenuItem.Name = "loginRegisterToolStripMenuItem";
            loginRegisterToolStripMenuItem.Size = new Size(96, 20);
            loginRegisterToolStripMenuItem.Text = "Login/Register";
            loginRegisterToolStripMenuItem.Click += loginRegisterToolStripMenuItem_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 325);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1739, 700);
            Controls.Add(label1);
            Controls.Add(pictureBoxBanner);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxBanner).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxBanner;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem aboutUsToolStripMenuItem;
        private ToolStripMenuItem loginRegisterToolStripMenuItem;
        private Label label1;
    }
}