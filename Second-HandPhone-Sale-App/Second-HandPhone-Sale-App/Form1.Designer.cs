namespace Second_HandPhone_Sale_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            buyPhonesToolStripMenuItem = new ToolStripMenuItem();
            sellPhonesToolStripMenuItem = new ToolStripMenuItem();
            registerLoginToolStripMenuItem = new ToolStripMenuItem();
            pictureBoxBanner = new PictureBox();
            bannerText = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBanner).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, buyPhonesToolStripMenuItem, sellPhonesToolStripMenuItem, registerLoginToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1162, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(52, 20);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // buyPhonesToolStripMenuItem
            // 
            buyPhonesToolStripMenuItem.Name = "buyPhonesToolStripMenuItem";
            buyPhonesToolStripMenuItem.Size = new Size(81, 20);
            buyPhonesToolStripMenuItem.Text = "Buy Phones";
            buyPhonesToolStripMenuItem.Click += buyPhonesToolStripMenuItem_Click;
            // 
            // sellPhonesToolStripMenuItem
            // 
            sellPhonesToolStripMenuItem.Name = "sellPhonesToolStripMenuItem";
            sellPhonesToolStripMenuItem.Size = new Size(79, 20);
            sellPhonesToolStripMenuItem.Text = "Sell Phones";
            sellPhonesToolStripMenuItem.Click += sellPhonesToolStripMenuItem_Click;
            // 
            // registerLoginToolStripMenuItem
            // 
            registerLoginToolStripMenuItem.Name = "registerLoginToolStripMenuItem";
            registerLoginToolStripMenuItem.Size = new Size(96, 20);
            registerLoginToolStripMenuItem.Text = "Register/Login";
            registerLoginToolStripMenuItem.Click += registerLoginToolStripMenuItem_Click;
            // 
            // pictureBoxBanner
            // 
            pictureBoxBanner.Image = Properties.Resources.george_beridze_n_nyzlZe1jw_unsplash;
            pictureBoxBanner.Location = new Point(0, 27);
            pictureBoxBanner.Name = "pictureBoxBanner";
            pictureBoxBanner.Size = new Size(1162, 543);
            pictureBoxBanner.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBanner.TabIndex = 1;
            pictureBoxBanner.TabStop = false;
            pictureBoxBanner.Paint += pictureBoxBanner_Paint;
            // 
            // bannerText
            // 
            bannerText.AutoSize = true;
            bannerText.Location = new Point(536, 573);
            bannerText.Name = "bannerText";
            bannerText.Size = new Size(38, 15);
            bannerText.TabIndex = 2;
            bannerText.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1162, 596);
            Controls.Add(bannerText);
            Controls.Add(pictureBoxBanner);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBanner).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private PictureBox pictureBoxBanner;
        private Label bannerText;
        private ToolStripMenuItem buyPhonesToolStripMenuItem;
        private ToolStripMenuItem sellPhonesToolStripMenuItem;
        private ToolStripMenuItem registerLoginToolStripMenuItem;
    }
}