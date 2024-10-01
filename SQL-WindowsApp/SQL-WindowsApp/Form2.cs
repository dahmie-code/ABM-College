using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_WindowsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CreateColorfulGrid();
        }
        private void CreateColorfulGrid()
        {
           
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.RowCount = 5;
            tableLayoutPanel.ColumnCount = 5;
            tableLayoutPanel.Dock = DockStyle.Fill;

            
            for (int i = 0; i < 5; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            }
            Random rnd = new Random();
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    Panel panel = new Panel();
                    panel.Dock = DockStyle.Fill;

                   
                    panel.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

                    
                    tableLayoutPanel.Controls.Add(panel, col, row);
                }
            }

            this.Controls.Add(tableLayoutPanel);
        }
    }
}
