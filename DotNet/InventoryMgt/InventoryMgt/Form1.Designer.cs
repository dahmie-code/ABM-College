namespace InventoryMgt
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
            btnAdd = new Button();
            btnRemove = new Button();
            itemLabel = new Label();
            quantityLabel = new Label();
            btnSave = new Button();
            btnInsert = new Button();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(204, 95);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(35, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "button1";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(204, 124);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(35, 23);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "button2";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // itemLabel
            // 
            itemLabel.AutoSize = true;
            itemLabel.Location = new Point(81, 112);
            itemLabel.Name = "itemLabel";
            itemLabel.Size = new Size(38, 15);
            itemLabel.TabIndex = 2;
            itemLabel.Text = "label1";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new Point(160, 112);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(38, 15);
            quantityLabel.TabIndex = 3;
            quantityLabel.Text = "label2";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(153, 153);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "button2";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(331, 153);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(86, 23);
            btnInsert.TabIndex = 5;
            btnInsert.Text = "button2";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(468, 153);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 23);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "button2";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(btnSave);
            Controls.Add(quantityLabel);
            Controls.Add(itemLabel);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnRemove;
        private Label itemLabel;
        private Label quantityLabel;
        private Button btnSave;
        private Button btnInsert;
        private Button btnUpdate;
    }
}