using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Second_HandPhone_Sale_App
{
    public partial class Buy : Form
    {
        private Dictionary<int, string[]> data;
        private int userId;
        private List<Phone> phones;
        private List<Phone> cart;
        private List<Phone> purchasedPhones;
        private Phone selectedPhone = null;
        private string userContact;
        public Buy(Dictionary<int, string[]> data, int userId, string userContact)
        {
            InitializeComponent();
            this.data = data ?? throw new ArgumentNullException(nameof(data));
            this.userId = userId;
            cart = new List<Phone>();
            purchasedPhones = new List<Phone>();
            InitializePhoneList();
            InitializeFilters();
            InitializeListView();
            profileToolStripMenuItem.Click += profileToolStripMenuItem_Click;
            this.userContact = userContact;
        }

        private void Buy_Load(object sender, EventArgs e)
        {
            logOutButton.Text = "Log Out";
            logOutButton.BackColor = Color.Red;
            checkOutButton.Text = "Checkout";
            buttonBuyNow.Text = "Buy Now";
            labelNoResults.Visible = false;
            labelNoResults.Text = string.Empty;

        }
        private void InitializePhoneList()
        {
            var assembly = Assembly.GetExecutingAssembly();
            phones = new List<Phone>();

            var imageNames = new string[]
            {
        "Second_HandPhone_Sale_App.Resources.amjith-s-yMubHZhtvas-unsplash.jpg",
        "Second_HandPhone_Sale_App.Resources.daniel-romero-aiUAxBNe3Xk-unsplash.jpg",
        "Second_HandPhone_Sale_App.Resources.evgeny-opanasenko-KMIlGDfC0YY-unsplash.jpg",
        "Second_HandPhone_Sale_App.Resources.george-beridze-n-nyzlZe1jw-unsplash.jpg",
        "Second_HandPhone_Sale_App.Resources.hamid-roshaan-Q7TEVokbCcM-unsplash.jpg",
               "Second_HandPhone_Sale_App.Resources.zeesha-SUGIhq_GrIs-unsplash.jpg"
            };


            var phoneDetails = new (string Model, decimal Price, string Condition, string SellerContact)[]
            {
        ("Google Pixel", 200, "Good", "123-456-7890"),
        ("OnePlus", 150, "Like New", "345-678-9012"),
        ("Samsung Galaxy", 300, "Fair", "234-567-8901"),
        ("iPhone", 250, "Excellent", "098-765-4321"),
        ("OnePlus", 150, "Good", "345-678-9012"),
         ("iPhone", 250, "Refurbished", "098-765-4321"),
            };

            for (int i = 0; i < imageNames.Length; i++)
            {
                using (var stream = assembly.GetManifestResourceStream(imageNames[i]))
                {
                    if (stream != null)
                    {
                        var image = Image.FromStream(stream);
                        phones.Add(new Phone
                        {
                            Image = image,
                            Model = phoneDetails[i].Model,
                            Price = phoneDetails[i].Price,
                            Condition = phoneDetails[i].Condition,
                            SellerContact = phoneDetails[i].SellerContact
                        });
                    }
                    else
                    {
                        MessageBox.Show($"Image resource {imageNames[i]} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void InitializeListView()
        {

            ImageList imageList = new ImageList
            {
                ImageSize = new Size(200, 200)
            };


            foreach (var phone in phones)
            {
                imageList.Images.Add(phone.Image);
            }


            listView1.LargeImageList = imageList;
            listView1.View = View.LargeIcon;
            listView1.AutoArrange = true;
            listView1.Alignment = ListViewAlignment.Top;
            listView1.Scrollable = true;
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            for (int i = 0; i < phones.Count; i++)
            {

                string itemText = $"{phones[i].Model}\n" +
                                   $"Price: ${phones[i].Price}\n" +
                                   $"Condition: {phones[i].Condition}\n" +
                                   $"Seller Contact: {phones[i].SellerContact}";

                ListViewItem item = new ListViewItem
                {
                    Text = itemText,
                    ImageIndex = i
                };

                listView1.Items.Add(item);
            }

            listView1.Margin = new Padding(0);

            listView1.ItemSelectionChanged += listView1_ItemSelectionChanged;
        }


        private void UpdateListView(List<Phone> filteredPhones)
        {
            listView1.Items.Clear();

            ImageList imageList = new ImageList
            {
                ImageSize = new Size(200, 200)
            };

            foreach (var phone in filteredPhones)
            {
                imageList.Images.Add(phone.Image);
            }

            listView1.LargeImageList = imageList;

            for (int i = 0; i < filteredPhones.Count; i++)
            {
                string itemText = $"{filteredPhones[i].Model}\n" +
                                  $"Price: ${filteredPhones[i].Price}\n" +
                                  $"Condition: {filteredPhones[i].Condition}\n" +
                                  $"Seller Contact: {filteredPhones[i].SellerContact}";

                ListViewItem item = new ListViewItem
                {
                    Text = itemText,
                    ImageIndex = i
                };

                listView1.Items.Add(item);
            }
        }



        private void InitializeFilters()
        {
            comboBoxBrand.Items.AddRange(new string[] { "--Brand--","All", "Google", "iPhone", "Samsung" });
            comboBoxPriceRange.Items.AddRange(new string[] { "--Price--", "All", "$0 - $100", "$100 - $200", "$200 - $300" });
            comboBoxCondition.Items.AddRange(new string[] { "--Condition--", "All", "Like New", "Refurbished", "Good", "Fair" });

            comboBoxBrand.SelectedIndex = 0;
            comboBoxPriceRange.SelectedIndex = 0;
                comboBoxCondition.SelectedIndex = 0;

            comboBoxBrand.SelectedIndexChanged += (sender, e) => ApplyFilters();
            comboBoxPriceRange.SelectedIndexChanged += (sender, e) => ApplyFilters();
            comboBoxCondition.SelectedIndexChanged += (sender, e) => ApplyFilters();
        }

        private void ApplyFilters(List<Phone> filteredPhones = null)
        {
            if (filteredPhones == null)
            {
                filteredPhones = phones;
            }

            // Filter by Brand
            if (comboBoxBrand.SelectedItem != null && comboBoxBrand.SelectedItem.ToString() != "All")
            {
                filteredPhones = filteredPhones.FindAll(p => p.Model.Contains(comboBoxBrand.SelectedItem.ToString()));
            }

            // Filter by Price Range
            if (comboBoxPriceRange.SelectedItem != null && comboBoxPriceRange.SelectedItem.ToString() != "All")
            {
                filteredPhones = filteredPhones.FindAll(p => p.Price >= GetMinPrice(comboBoxPriceRange.SelectedItem.ToString())
                                                             && p.Price <= GetMaxPrice(comboBoxPriceRange.SelectedItem.ToString()));
            }

            // Filter by Condition
            if (comboBoxCondition.SelectedItem != null && comboBoxCondition.SelectedItem.ToString() != "All")
            {
                filteredPhones = filteredPhones.FindAll(p => p.Condition.Equals(comboBoxCondition.SelectedItem.ToString()));
            }

            if (filteredPhones.Count == 0)
            {
                labelNoResults.Visible = true;
                return;
            }
            else
            {
                labelNoResults.Visible = false;
            }
            UpdateListView(filteredPhones);
        }


        private decimal GetMinPrice(string priceRange)
        {
            var priceParts = priceRange.Replace("$", "").Split('-');
            return decimal.Parse(priceParts[0].Trim());
        }

        private decimal GetMaxPrice(string priceRange)
        {
            var priceParts = priceRange.Replace("$", "").Split('-');
            return decimal.Parse(priceParts[1].Trim());
        }

        public class Phone
        {
            public Image Image { get; set; }
            public string Model { get; set; }
            public decimal Price { get; set; }
            public string Condition { get; set; }
            public string SellerContact { get; set; }
        }
        private void buttonBuyNow_Click(object sender, EventArgs e)
        {
            if (selectedPhone != null)
            {
                cart.Add(selectedPhone);
                MessageBox.Show($"{selectedPhone.Model} has been added to your cart.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                selectedPhone = null;
            }
            else
            {
                MessageBox.Show("Please select a phone first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Checkout()
        {
            purchasedPhones.AddRange(cart);
            cart.Clear();
            MessageBox.Show("Purchase completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                int index = e.ItemIndex;


                if (index >= 0 && index < phones.Count)
                {
                    selectedPhone = phones[index];
                    ShowPhoneDetails(selectedPhone);
                }
            }
        }
        private void ShowPhoneDetails(Phone phone)
        {

            MessageBox.Show($"Model: {phone.Model}\nPrice: ${phone.Price}\nCondition: {phone.Condition}\nSeller Contact: {phone.SellerContact}",
                            "Phone Details",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
        private void logOutButton_Click_1(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            this.Hide();
            loginForm.ShowDialog();
            this.Close(); 
        }

        private void checkOutButton_Click_1(object sender, EventArgs e)
        {
            ShowCartDetails();
            Checkout();
        }
        private void ShowCartDetails()
        {
            StringBuilder cartDetails = new StringBuilder();

            foreach (var phone in cart)
            {
                cartDetails.AppendLine($"Model: {phone.Model}");
                cartDetails.AppendLine($"Price: ${phone.Price}");
                cartDetails.AppendLine($"Condition: {phone.Condition}");
                cartDetails.AppendLine();
            }

            MessageBox.Show(cartDetails.ToString(), "Cart Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchBar.Text.Trim().ToLower();
            var filteredPhones = phones.Where(p => p.Model.ToLower().Contains(searchText)).ToList();
            if (filteredPhones.Count == 0)
            {
                labelNoResults.Visible = true;
                return;
            }
            else
            {
                labelNoResults.Visible = false;
            }
            ApplyFilters(filteredPhones);
        }
        private void myPurchasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyPurchasesForm purchasesForm = new MyPurchasesForm(purchasedPhones, "username", data, userId, userContact);
            purchasesForm.ShowDialog();
        }
        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (data == null)
            {
                MessageBox.Show("User data is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserProfileForm profileForm = new UserProfileForm(data, userId);
            profileForm.ShowDialog();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home homeForm = new Home(userContact, data, userId, userContact);
            homeForm.ShowDialog();
        }

        private void sellPhonesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Sell sellForm = new Sell(userContact, data, userId);
            sellForm.ShowDialog();
        }
    }
}
