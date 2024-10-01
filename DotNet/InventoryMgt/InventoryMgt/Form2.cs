using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMgt
{
    public partial class Form2 : Form
    {
        private Form3 form3;
        private int sizeChangeCount = 0;
        private int previousWidth, previousHeight;
        
        public Form2()
        {
            InitializeComponent();
            previousWidth = this.Width;
            previousHeight = this.Height;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            form3 = new Form3(this);
            form3.Show();
            countLabel.Text = sizeChangeCount.ToString();
;
        }
        public void UpdateLabel(int count, string changeType)
        {
            countLabel.Text = $"Form2 - Form3 size changes: {count} ({changeType})";
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            int widthChange = this.Width - previousWidth;
            int heightChange = this.Height - previousHeight;

            previousWidth = this.Width;
            previousHeight = this.Height;

            if (widthChange > 0 || heightChange > 0)
            {
                sizeChangeCount++;
                NotifyForm3("Increased");
            }
            else if (widthChange < 0 || heightChange < 0)
            {
                sizeChangeCount--;
                NotifyForm3("Decreased");
            }
        }
        private void NotifyForm3(string changeType)
        {
            if (form3 != null)
            {
                form3.UpdateLabel(sizeChangeCount, changeType);
            }
        }
    }
}
