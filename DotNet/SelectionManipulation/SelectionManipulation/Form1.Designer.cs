namespace SelectionManipulation
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
            comboContinents = new ComboBox();
            comboCountries = new ComboBox();
            comboStates = new ComboBox();
            continent = new Label();
            countries = new Label();
            state = new Label();
            SuspendLayout();
            // 
            // comboContinents
            // 
            comboContinents.FormattingEnabled = true;
            comboContinents.Location = new Point(91, 82);
            comboContinents.Name = "comboContinents";
            comboContinents.Size = new Size(177, 23);
            comboContinents.TabIndex = 0;
            comboContinents.SelectedIndexChanged += comboContinents_SelectedIndexChanged;
            // 
            // comboCountries
            // 
            comboCountries.FormattingEnabled = true;
            comboCountries.Location = new Point(427, 82);
            comboCountries.Name = "comboCountries";
            comboCountries.Size = new Size(173, 23);
            comboCountries.TabIndex = 1;
            comboCountries.SelectedIndexChanged += comboCountries_SelectedIndexChanged;
            // 
            // comboStates
            // 
            comboStates.FormattingEnabled = true;
            comboStates.Location = new Point(785, 82);
            comboStates.Name = "comboStates";
            comboStates.Size = new Size(193, 23);
            comboStates.TabIndex = 2;
            comboStates.SelectedIndexChanged += comboStates_SelectedIndexChanged;
            // 
            // continent
            // 
            continent.AutoSize = true;
            continent.Location = new Point(12, 90);
            continent.Name = "continent";
            continent.Size = new Size(38, 15);
            continent.TabIndex = 3;
            continent.Text = "label1";
            // 
            // countries
            // 
            countries.AutoSize = true;
            countries.Location = new Point(322, 90);
            countries.Name = "countries";
            countries.Size = new Size(38, 15);
            countries.TabIndex = 4;
            countries.Text = "label1";
            // 
            // state
            // 
            state.AutoSize = true;
            state.Location = new Point(693, 90);
            state.Name = "state";
            state.Size = new Size(38, 15);
            state.TabIndex = 5;
            state.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 539);
            Controls.Add(state);
            Controls.Add(countries);
            Controls.Add(continent);
            Controls.Add(comboStates);
            Controls.Add(comboCountries);
            Controls.Add(comboContinents);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboContinents;
        private ComboBox comboCountries;
        private ComboBox comboStates;
        private Label continent;
        private Label countries;
        private Label state;
    }
}