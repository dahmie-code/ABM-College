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
    public partial class Form3 : Form
    {
        private Form2 form2;
        private int previousWidth, previousHeight;
        private int sizeChangeCount = 0;
        public Form3(Form2 parentForm)
        {
            InitializeComponent();
            form2 = parentForm;
            previousWidth = this.Width;
            previousHeight = this.Height;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            countLabel.Text = "0";
        }
        public void UpdateLabel(int count, string changeType)
        {
            countLabel.Text = $"Form3 - Form2 size changes: {count} ({changeType})";
        }
        private void Form3_Resize(object sender, EventArgs e)
        {
            int widthChange = this.Width - previousWidth;
            int heightChange = this.Height - previousHeight;

            previousWidth = this.Width;
            previousHeight = this.Height;

            if (widthChange > 0 || heightChange > 0)
            {
                sizeChangeCount++;
                NotifyForm2("Increased");
            }
            else if (widthChange < 0 || heightChange < 0)
            {
                sizeChangeCount--;
                NotifyForm2("Decreased");
            }
        }
        private void NotifyForm2(string changeType)
        {
            if (form2 != null)
            {
                form2.UpdateLabel(sizeChangeCount, changeType);
            }
        }
    }
}
