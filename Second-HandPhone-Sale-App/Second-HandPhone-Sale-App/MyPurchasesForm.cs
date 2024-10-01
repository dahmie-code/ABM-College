using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Second_HandPhone_Sale_App
{
    public partial class MyPurchasesForm : Form
    {
        private string user;
        private List<Buy.Phone> purchasedPhones;
        private Dictionary<int, string[]> data;
        private int userId;
        private string userContact;
        public MyPurchasesForm(List<Buy.Phone> purchasedPhones, string user, Dictionary<int, string[]> data, int userId, string userContact)
        {
            InitializeComponent();
            this.purchasedPhones = purchasedPhones ?? new List<Buy.Phone>();
            this.user = user;
            this.data = data ?? new Dictionary<int, string[]>();
            this.userId = userId;
            InitializePurchaseListView();
            this.userContact = userContact;
        }

        private void MyPurchasesForm_Load(object sender, EventArgs e)
        {
            logOutButton.Text = "Log Out";
            logOutButton.BackColor = Color.Red;
        }
        private void InitializePurchaseListView()
        {
            listViewPurchases.View = View.Details;
            listViewPurchases.Columns.Add("Model", 120);
            listViewPurchases.Columns.Add("Price", 80);
            listViewPurchases.Columns.Add("Condition", 100);
            listViewPurchases.Columns.Add("Seller Contact", 150);

            foreach (var phone in purchasedPhones)
            {
                ListViewItem item = new ListViewItem(phone.Model);
                item.SubItems.Add(phone.Price.ToString("C"));
                item.SubItems.Add(phone.Condition);
                item.SubItems.Add(phone.SellerContact);
                listViewPurchases.Items.Add(item);
            }

            listViewPurchases.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home HomeForm = new Home(user, data, userId, userContact);
            HomeForm.ShowDialog();
        }

        private void buyPhonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buy BuyForm = new Buy(data, userId, userContact);
            BuyForm.ShowDialog();
        }

        private void sellPhonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sell SellForm = new Sell(userContact, data, userId);
            SellForm.ShowDialog();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyListingsForm listingsForm = new MyListingsForm(data, userId, userContact);
            listingsForm.ShowDialog();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Login LoginForm = new Login();
            LoginForm.ShowDialog();
        }
    }
}
