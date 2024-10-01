using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace E_commerce_Tool
{
    public partial class Form4 : Form
    {

        Dictionary<string, decimal> selectedItems = new Dictionary<string, decimal>();
        decimal discount = 0m;
        public Form4()
        {

            InitializeComponent();
            InitializeUI();
            LoadBannerImage();


        }
        private void InitializeUI()
        {
            this.Size = new Size(800, 600);
            this.MinimumSize = new Size(800, 600);
            this.Text = "Cost Calculation";
            this.BackColor = Color.White;
            this.Font = new Font("Segoe UI", 16);
            //this.AutoScroll = true;
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100);


            buttonHome.Text = "Home";
            buttonHome.FlatStyle = FlatStyle.Flat;
            buttonHome.BackColor = Color.Teal;
            buttonHome.ForeColor = Color.White;
            buttonHome.Click += buttonHome_Click;
            buttonHome.Location = new Point(20, 20);



            buttonReset.Text = "Reset";
            buttonReset.FlatStyle = FlatStyle.Flat;
            buttonReset.BackColor = Color.LightGray;
            buttonReset.Click += buttonReset_Click;

            buttonCheckout.Text = "Checkout";
            buttonCheckout.FlatStyle = FlatStyle.Flat;
            buttonCheckout.BackColor = Color.Teal;
            buttonCheckout.ForeColor = Color.White;
            buttonCheckout.Click += buttonCheckout_Click;

            total.Text = "Total";
            labelDiscount.Text = "Apply discount";
            label1.Text = "";


            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            string[] categories = { "--Category--", "Electronics", "Clothing", };
            comboBoxCategory.Items.AddRange(categories);
            comboBoxCategory.SelectedIndex = 0;

            comboBoxCategory.SelectedIndexChanged += comboBoxCategory_SelectedIndexChanged;

            comboBoxDiscount.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDiscount.Items.Add("10% Off");
            comboBoxDiscount.Items.Add("$5 Off");
            comboBoxDiscount.SelectedIndexChanged += comboBoxDiscount_SelectedIndexChanged;


            checkedListBoxItems.CheckOnClick = true;
            checkedListBoxItems.ItemCheck += CheckedListBoxItems_ItemCheck;


            textBoxTotalCost.ReadOnly = true;
            textBoxTotalCost.BackColor = Color.LightGray;
            textBoxTotalCost.Anchor = AnchorStyles.Top | AnchorStyles.Right;


        }

        private async void LoadBannerImage()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    byte[] imageData = await client.GetByteArrayAsync("https://images.unsplash.com/photo-1633926248455-d729718e0886?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D");

                    using (MemoryStream stream = new MemoryStream(imageData))
                    {
                        pictureBoxBanner.Image = Image.FromStream(stream);
                        pictureBoxBanner.SizeMode = PictureBoxSizeMode.StretchImage;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load banner image: {ex.Message}");
            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            comboBoxCategory.Text = "--Category--";
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBoxItems.Items.Clear();
            if (comboBoxCategory.SelectedItem != null)
            {
                string selectedCategory = comboBoxCategory.SelectedItem.ToString();


                if (selectedCategory == "Electronics")
                {

                    checkedListBoxItems.Items.Add("Laptop - $1000", false);
                    checkedListBoxItems.Items.Add("Smartphone - $800", false);
                }
                else if (selectedCategory == "Clothing")
                {
                    checkedListBoxItems.Items.Add("Shirt - $200", false);
                    checkedListBoxItems.Items.Add("Jeans - $40", false);
                }
            }
            else
            {

                MessageBox.Show("Please select a category.");
            }
        }

        private void CheckedListBoxItems_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string item = checkedListBoxItems.Items[e.Index].ToString();
            decimal price = GetItemPrice(item);
            if (e.NewValue == CheckState.Checked)
            {
                selectedItems[item] = price;
            }
            else
            {
                selectedItems.Remove(item);
            }
            UpdateTotalCost();
        }

        private decimal GetItemPrice(string item)
        {
            string pricePart = item.Split('-')[1].Trim().TrimStart('$');
            if (decimal.TryParse(pricePart, out decimal price))
            {
                return price;
            }
            else
            {
                MessageBox.Show("Error: Price format is incorrect.");
                return 0m;
            }
        }





        private void UpdateTotalCost()
        {
            decimal total = selectedItems.Values.Sum();
            if (discount < 1)
            {
                total -= total * discount;
            }
            else
            {
                total -= discount;
            }

            if (total < 0)
            {
                total = 0;
            }

            textBoxTotalCost.Text = $"${total:F2}";
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            selectedItems.Clear();
            checkedListBoxItems.ClearSelected();
            textBoxTotalCost.Clear();
            comboBoxCategory.SelectedIndex = -1;
            comboBoxDiscount.SelectedIndex = -1;
            label1.Text = "";
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Total cost is {textBoxTotalCost.Text}.\n Purchase successful!");

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Form3 homeForm = new Form3();
            homeForm.Show();
            this.Hide();
        }

        private void comboBoxDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            string discountText = comboBoxDiscount.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(discountText))
            {
                discount = 0m;
                label1.Text = "No discount applied.";
                return;
            }

            try
            {
                if (discountText.Contains("%"))
                {
                    string percentage = discountText.TrimEnd('%', ' ', 'O', 'f', 'f');
                    if (decimal.TryParse(percentage, out decimal percentageDiscount))
                    {
                        discount = percentageDiscount / 100;
                        label1.Text = $"{percentage}% discount applied successfully";
                    }
                    else
                    {
                        MessageBox.Show("Invalid percentage format.");
                        discount = 0m;
                    }
                }
                else if (discountText.Contains("$"))
                {
                    string flatRate = discountText.TrimStart('$').TrimEnd(' ', 'O', 'f', 'f');
                    if (decimal.TryParse(flatRate, out decimal flatRateDiscount))
                    {
                        discount = flatRateDiscount;
                        label1.Text = $"${flatRate} discount applied successfully";
                    }
                    else
                    {
                        MessageBox.Show("Invalid flat-rate format.");
                        discount = 0m;
                    }
                }
                else
                {
                    MessageBox.Show("Unknown discount format.");
                    discount = 0m;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error parsing discount: {ex.Message}");
                discount = 0m;
            }

            UpdateTotalCost();
        }
    }
}
