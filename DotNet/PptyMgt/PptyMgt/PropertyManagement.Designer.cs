namespace PptyMgt
{
    partial class PropertyManagement
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
            btnAdd = new Button();
            dataGridView1 = new DataGridView();
            updateBtn = new Button();
            deleteBtn = new Button();
            txtMinPrice = new TextBox();
            txtType = new TextBox();
            txtState = new TextBox();
            txtMaxPrice = new TextBox();
            txtCity = new TextBox();
            btnFilter = new Button();
            minPriceLabel = new Label();
            maxPriceLabel = new Label();
            typeLabel = new Label();
            cityLabel = new Label();
            stateLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(14, 416);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(153, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "button1";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 314);
            dataGridView1.TabIndex = 4;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(173, 416);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(153, 23);
            updateBtn.TabIndex = 5;
            updateBtn.Text = "button1";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(332, 416);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(153, 23);
            deleteBtn.TabIndex = 6;
            deleteBtn.Text = "button1";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // txtMinPrice
            // 
            txtMinPrice.Location = new Point(76, 30);
            txtMinPrice.Name = "txtMinPrice";
            txtMinPrice.Size = new Size(153, 23);
            txtMinPrice.TabIndex = 7;
            // 
            // txtType
            // 
            txtType.Location = new Point(304, 30);
            txtType.Name = "txtType";
            txtType.Size = new Size(153, 23);
            txtType.TabIndex = 8;
            // 
            // txtState
            // 
            txtState.Location = new Point(541, 30);
            txtState.Name = "txtState";
            txtState.Size = new Size(153, 23);
            txtState.TabIndex = 9;
            // 
            // txtMaxPrice
            // 
            txtMaxPrice.Location = new Point(76, 67);
            txtMaxPrice.Name = "txtMaxPrice";
            txtMaxPrice.Size = new Size(153, 23);
            txtMaxPrice.TabIndex = 10;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(304, 66);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(153, 23);
            txtCity.TabIndex = 11;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(541, 66);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(93, 23);
            btnFilter.TabIndex = 12;
            btnFilter.Text = "button1";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // minPriceLabel
            // 
            minPriceLabel.AutoSize = true;
            minPriceLabel.Location = new Point(12, 38);
            minPriceLabel.Name = "minPriceLabel";
            minPriceLabel.Size = new Size(38, 15);
            minPriceLabel.TabIndex = 13;
            minPriceLabel.Text = "label1";
            // 
            // maxPriceLabel
            // 
            maxPriceLabel.AutoSize = true;
            maxPriceLabel.Location = new Point(12, 75);
            maxPriceLabel.Name = "maxPriceLabel";
            maxPriceLabel.Size = new Size(38, 15);
            maxPriceLabel.TabIndex = 14;
            maxPriceLabel.Text = "label2";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new Point(246, 38);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(38, 15);
            typeLabel.TabIndex = 15;
            typeLabel.Text = "label3";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(246, 74);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(38, 15);
            cityLabel.TabIndex = 16;
            cityLabel.Text = "label4";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new Point(472, 38);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new Size(38, 15);
            stateLabel.TabIndex = 17;
            stateLabel.Text = "label5";
            // 
            // PropertyManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(stateLabel);
            Controls.Add(cityLabel);
            Controls.Add(typeLabel);
            Controls.Add(maxPriceLabel);
            Controls.Add(minPriceLabel);
            Controls.Add(btnFilter);
            Controls.Add(txtCity);
            Controls.Add(txtMaxPrice);
            Controls.Add(txtState);
            Controls.Add(txtType);
            Controls.Add(txtMinPrice);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(dataGridView1);
            Controls.Add(btnAdd);
            Name = "PropertyManagement";
            Text = "PropertyManagement";
            Load += PropertyManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAdd;
        private DataGridView dataGridView1;
        private Button updateBtn;
        private Button deleteBtn;
        private TextBox txtMinPrice;
        private TextBox txtType;
        private TextBox txtState;
        private TextBox txtMaxPrice;
        private TextBox txtCity;
        private Button btnFilter;
        private Label minPriceLabel;
        private Label maxPriceLabel;
        private Label typeLabel;
        private Label cityLabel;
        private Label stateLabel;
    }
}