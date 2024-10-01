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

namespace E_commerce_Tool
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label2.Text = $"Welcome to ShopSmart, your go-to platform for a seamless and enjoyable shopping experience.\n " +
                "Our mission is to provide a simple yet powerful tool that helps you make informed purchasing decisions with ease. \r\n\r" +
                "Whether you're looking to calculate costs, apply discounts, or explore our latest offers, ShopSmart is designed to be your reliable shopping companion.";

            label2.Font = new Font(label1.Font.FontFamily, 14);

            label1.Text = "ABOUT US";
            label1.Font = new Font(label1.Font, FontStyle.Bold);
            label1.Font = new Font(label1.Font.FontFamily, 25);



        }
    }
}
