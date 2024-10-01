namespace E_commerce_Tool
{
    partial class Form4
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
            total = new Label();
            comboBoxCategory = new ComboBox();
            checkedListBoxItems = new CheckedListBox();
            buttonHome = new Button();
            buttonCheckout = new Button();
            buttonReset = new Button();
            pictureBoxBanner = new PictureBox();
            textBoxTotalCost = new TextBox();
            comboBoxDiscount = new ComboBox();
            labelDiscount = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBanner).BeginInit();
            SuspendLayout();
            // 
            // total
            // 
            total.AutoSize = true;
            total.Location = new Point(289, 329);
            total.Name = "total";
            total.Size = new Size(38, 15);
            total.TabIndex = 0;
            total.Text = "label1";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(288, 198);
            comboBoxCategory.Margin = new Padding(3, 2, 3, 2);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(258, 23);
            comboBoxCategory.TabIndex = 1;
            comboBoxCategory.SelectedIndexChanged += comboBoxCategory_SelectedIndexChanged;
            // 
            // checkedListBoxItems
            // 
            checkedListBoxItems.FormattingEnabled = true;
            checkedListBoxItems.Location = new Point(288, 225);
            checkedListBoxItems.Margin = new Padding(3, 2, 3, 2);
            checkedListBoxItems.Name = "checkedListBoxItems";
            checkedListBoxItems.Size = new Size(260, 76);
            checkedListBoxItems.TabIndex = 2;
            // 
            // buttonHome
            // 
            buttonHome.Location = new Point(12, 11);
            buttonHome.Margin = new Padding(3, 2, 3, 2);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(82, 22);
            buttonHome.TabIndex = 4;
            buttonHome.Text = "button1";
            buttonHome.UseVisualStyleBackColor = true;
            buttonHome.Click += buttonHome_Click;
            // 
            // buttonCheckout
            // 
            buttonCheckout.Location = new Point(494, 325);
            buttonCheckout.Margin = new Padding(3, 2, 3, 2);
            buttonCheckout.Name = "buttonCheckout";
            buttonCheckout.Size = new Size(82, 22);
            buttonCheckout.TabIndex = 5;
            buttonCheckout.Text = "button2";
            buttonCheckout.UseVisualStyleBackColor = true;
            buttonCheckout.Click += buttonCheckout_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(333, 360);
            buttonReset.Margin = new Padding(3, 2, 3, 2);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(92, 22);
            buttonReset.TabIndex = 6;
            buttonReset.Text = "button3";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // pictureBoxBanner
            // 
            pictureBoxBanner.Image = Properties.Resources.finn_czCKSIKX0Us_unsplash;
            pictureBoxBanner.Location = new Point(0, 41);
            pictureBoxBanner.Margin = new Padding(3, 2, 3, 2);
            pictureBoxBanner.Name = "pictureBoxBanner";
            pictureBoxBanner.Size = new Size(1166, 150);
            pictureBoxBanner.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBanner.TabIndex = 7;
            pictureBoxBanner.TabStop = false;
            // 
            // textBoxTotalCost
            // 
            textBoxTotalCost.Location = new Point(333, 324);
            textBoxTotalCost.Margin = new Padding(3, 2, 3, 2);
            textBoxTotalCost.Name = "textBoxTotalCost";
            textBoxTotalCost.Size = new Size(111, 23);
            textBoxTotalCost.TabIndex = 8;
            // 
            // comboBoxDiscount
            // 
            comboBoxDiscount.FormattingEnabled = true;
            comboBoxDiscount.Location = new Point(561, 251);
            comboBoxDiscount.Margin = new Padding(3, 2, 3, 2);
            comboBoxDiscount.Name = "comboBoxDiscount";
            comboBoxDiscount.Size = new Size(68, 23);
            comboBoxDiscount.TabIndex = 9;
            comboBoxDiscount.SelectedIndexChanged += comboBoxDiscount_SelectedIndexChanged;
            // 
            // labelDiscount
            // 
            labelDiscount.AutoSize = true;
            labelDiscount.Location = new Point(561, 234);
            labelDiscount.Name = "labelDiscount";
            labelDiscount.Size = new Size(38, 15);
            labelDiscount.TabIndex = 10;
            labelDiscount.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(288, 303);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 11;
            label1.Text = "label1";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 538);
            Controls.Add(label1);
            Controls.Add(labelDiscount);
            Controls.Add(comboBoxDiscount);
            Controls.Add(textBoxTotalCost);
            Controls.Add(pictureBoxBanner);
            Controls.Add(buttonReset);
            Controls.Add(buttonCheckout);
            Controls.Add(buttonHome);
            Controls.Add(checkedListBoxItems);
            Controls.Add(comboBoxCategory);
            Controls.Add(total);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxBanner).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label total;
        private ComboBox comboBoxCategory;
        private CheckedListBox checkedListBoxItems;
        private Button buttonHome;
        private Button buttonCheckout;
        private Button buttonReset;
        private PictureBox pictureBoxBanner;
        private TextBox textBoxTotalCost;
        private ComboBox comboBoxDiscount;
        private Label labelDiscount;
        private Label label1;
    }
}