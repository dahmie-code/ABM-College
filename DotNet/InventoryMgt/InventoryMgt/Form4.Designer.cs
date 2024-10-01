namespace InventoryMgt
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
            label1 = new Label();
            txtEmail = new TextBox();
            btnSubmit = new Button();
            lblError = new Label();
            label2 = new Label();
            btnCount = new Button();
            lblWordPunctuationResult = new Label();
            sentenceLabel = new Label();
            lblCharacterResult = new Label();
            btnfilter = new Button();
            lblResult = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(95, 376);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(212, 23);
            txtEmail.TabIndex = 1;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(163, 420);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "button1";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(95, 402);
            lblError.Name = "lblError";
            lblError.Size = new Size(38, 15);
            lblError.TabIndex = 3;
            lblError.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 384);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // btnCount
            // 
            btnCount.Location = new Point(397, 152);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(156, 23);
            btnCount.TabIndex = 5;
            btnCount.Text = "button1";
            btnCount.UseVisualStyleBackColor = true;
            btnCount.Click += btnCount_Click;
            // 
            // lblWordPunctuationResult
            // 
            lblWordPunctuationResult.AutoSize = true;
            lblWordPunctuationResult.Location = new Point(458, 187);
            lblWordPunctuationResult.Name = "lblWordPunctuationResult";
            lblWordPunctuationResult.Size = new Size(38, 15);
            lblWordPunctuationResult.TabIndex = 7;
            lblWordPunctuationResult.Text = "label2";
            // 
            // sentenceLabel
            // 
            sentenceLabel.AutoSize = true;
            sentenceLabel.Location = new Point(200, 126);
            sentenceLabel.Name = "sentenceLabel";
            sentenceLabel.Size = new Size(38, 15);
            sentenceLabel.TabIndex = 8;
            sentenceLabel.Text = "label2";
            // 
            // lblCharacterResult
            // 
            lblCharacterResult.AutoSize = true;
            lblCharacterResult.Location = new Point(629, 156);
            lblCharacterResult.Name = "lblCharacterResult";
            lblCharacterResult.Size = new Size(38, 15);
            lblCharacterResult.TabIndex = 9;
            lblCharacterResult.Text = "label2";
            // 
            // btnfilter
            // 
            btnfilter.Location = new Point(58, 165);
            btnfilter.Name = "btnfilter";
            btnfilter.Size = new Size(75, 23);
            btnfilter.TabIndex = 10;
            btnfilter.Text = "button1";
            btnfilter.UseVisualStyleBackColor = true;
            btnfilter.Click += btnfilter_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(71, 191);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(38, 15);
            lblResult.TabIndex = 11;
            lblResult.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 149);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 12;
            label3.Text = "label2";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(lblResult);
            Controls.Add(btnfilter);
            Controls.Add(lblCharacterResult);
            Controls.Add(sentenceLabel);
            Controls.Add(lblWordPunctuationResult);
            Controls.Add(btnCount);
            Controls.Add(label2);
            Controls.Add(lblError);
            Controls.Add(btnSubmit);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            FormClosing += Form4_FormClosing;
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private Button btnSubmit;
        private Label lblError;
        private Label label2;
        private Button btnCount;
        private Label lblCharacterResult;
        private Label lblWordPunctuationResult;
        private Label sentenceLabel;
        private Button btnfilter;
        private Label lblResult;
        private Label label3;
    }
}