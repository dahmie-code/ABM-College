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

namespace Menu
{
    public partial class Form2 : Form
    {
        private Dictionary<string, double> itemPrices = new Dictionary<string, double>();
        private Dictionary<string, int> itemQuantities = new Dictionary<string, int>();
        private double subtotal = 0;
        private double finalTotal = 0;
        private string receiptText = string.Empty;
        public Form2()
        {
            InitializeComponent();
            label1.Text = "HOME";

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button1.Text = "Hamburger (Beef)";
            button1.Font = new Font(button1.Font, FontStyle.Bold);

            receiptTextBox.ReadOnly = true;

            button2.Text = "Double Creamy Bacon\n $12";
            textBox1.Visible = false;
            button2.Visible = false;
            button13.Visible = false;
            button14.Visible = false;

            button3.Text = "Hamburger (Chicken)";
            button3.Font = new Font(button3.Font, FontStyle.Bold);
            textBox2.Visible = false;
            button4.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button4.Text = "Sweet Chili Chicken\n $17";

            button5.Text = "Coffee";
            button5.Font = new Font(button5.Font, FontStyle.Bold);
            button6.Text = "Cold Brew\n $2";
            textBox3.Visible = false;
            button6.Visible = false;
            button17.Visible = false;
            button18.Visible = false;

            checkOut.Text = "Checkout";

            Button[] buttons = { button14, button16, button18, };
            foreach (Button btn in buttons)
            {
                btn.Text = "+";
                btn.Visible = false;
            }

            Button[] buttons2 = { button13, button15, button17, };
            foreach (Button btn in buttons2)
            {
                btn.Text = "-";
                btn.Visible = false;

            }

            TextBox[] textboxes = { textBox1, textBox2, textBox3 };
            foreach (TextBox txt in textboxes)
            {
                txt.Visible = false;
                txt.ReadOnly = true;
                txt.Text = "0";
            }

            itemQuantities["Double Creamy Bacon"] = 0;
            itemQuantities["Sweet Chili Chicken"] = 0;
            itemQuantities["Cold Brew"] = 0;


        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Visible = true;
            button2.Visible = true;
            button13.Visible = true;
            button14.Visible = true;

            if (!itemPrices.ContainsKey("Double Creamy Bacon"))
            {
                itemPrices["Double Creamy Bacon"] = 12.00;
                itemQuantities["Double Creamy Bacon"] = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            button4.Visible = true;
            button15.Visible = true;
            button16.Visible = true;

            if (!itemPrices.ContainsKey("Sweet Chili Chicken"))
            {
                itemPrices["Sweet Chili Chicken"] = 17.00;
                itemQuantities["Sweet Chili Chicken"] = 0;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Visible = true;
            button6.Visible = true;
            button17.Visible = true;
            button18.Visible = true;

            if (!itemPrices.ContainsKey("Cold Brew"))
            {
                itemPrices["Cold Brew"] = 2.00;
                itemQuantities["Cold Brew"] = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double price = 12.00;
            AddToTotal("Double Creamy Bacon", price);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double price = 17.00;
            AddToTotal("Sweet Chili Chicken", price);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            double price = 2.00;
            AddToTotal("Cold Brew", price);
        }
        private void AddToTotal(string itemName, double price)
        {
            receiptTextBox.Font = new Font(receiptTextBox.Font.FontFamily, 10);
            itemQuantities[itemName]++;

            UpdateTotals(itemName);
        }

        private void checkOut_Click(object sender, EventArgs e)
        {
            finalTotal = subtotal;
            receiptText += $"\nFinal Total: ${finalTotal:F2}";
            receiptTextBox.Text = receiptText;
        }
        private void UpdateTotals(string itemName)
        {
            double itemTotal = itemPrices[itemName] * itemQuantities[itemName];
            subtotal = itemPrices.Sum(item => item.Value * itemQuantities[item.Key]);

            receiptText += $"{itemName} - ${itemPrices[itemName]:F2} x {itemQuantities[itemName]} = ${itemTotal:F2}\n";
            receiptText += $"Subtotal: ${subtotal:F2}\n";
            receiptTextBox.Text = receiptText;
        }
        private void button14_Click(object sender, EventArgs e)
        {
            if (itemQuantities.ContainsKey("Double Creamy Bacon"))
            {
                itemQuantities["Double Creamy Bacon"]++;
                textBox1.Text = itemQuantities["Double Creamy Bacon"].ToString();
                UpdateTotals("Double Creamy Bacon");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (itemQuantities.ContainsKey("Double Creamy Bacon") && itemQuantities["Double Creamy Bacon"] > 0)
            {
                itemQuantities["Double Creamy Bacon"]--;
                textBox1.Text = itemQuantities["Double Creamy Bacon"].ToString();
                UpdateTotals("Double Creamy Bacon");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (itemQuantities.ContainsKey("Sweet Chili Chicken")) {
                itemQuantities["Sweet Chili Chicken"]++;
                textBox2.Text = itemQuantities["Sweet Chili Chicken"].ToString();
                UpdateTotals("Sweet Chili Chicken");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (itemQuantities.ContainsKey("Sweet Chili Chicken") && itemQuantities["Sweet Chili Chicken"] > 0)
            {
                itemQuantities["Sweet Chili Chicken"]--;
                textBox2.Text = itemQuantities["Sweet Chili Chicken"].ToString();
                UpdateTotals("Sweet Chili Chicken");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (itemQuantities.ContainsKey("Cold Brew"))
            {
            itemQuantities["Cold Brew"]++;
            textBox3.Text = itemQuantities["Cold Brew"].ToString();
            UpdateTotals("Cold Brew");
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (itemQuantities.ContainsKey("Cold Brew") && itemQuantities["Cold Brew"] > 0)
            {
                itemQuantities["Cold Brew"]--;
                textBox3.Text = itemQuantities["Cold Brew"].ToString();
                UpdateTotals("Cold Brew");
            }
        }
    }
}
