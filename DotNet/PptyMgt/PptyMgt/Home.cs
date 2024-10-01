using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PptyMgt
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

        }

        private void Home_Load(object sender, EventArgs e)
        {
            SetupForm();
        }
        private void SetupForm()
        {
           
            this.BackgroundImage = Properties.Resources.avi_waxman_f9qZuKoZYoY_unsplash;
            this.BackgroundImageLayout = ImageLayout.Stretch;

       
            Panel panelOverlay = new Panel();
            panelOverlay.Dock = DockStyle.Fill;
            panelOverlay.BackColor = Color.FromArgb(170, 0, 0, 0);


            Button btnViewProperties = new Button();
            btnViewProperties.Text = "View Properties";
            btnViewProperties.Size = new Size(150, 50);
            btnViewProperties.Location = new Point(50, 50);
            btnViewProperties.BackColor = Color.White;

            Button btnViewOwners = new Button();
            btnViewOwners.Text = "View Owners";
            btnViewOwners.Size = new Size(150, 50);
            btnViewOwners.Location = new Point(120, 50);
            btnViewOwners.BackColor = Color.White;

            Button btnViewTransactions = new Button();
            btnViewTransactions.Text = "View Transactions";
            btnViewTransactions.Size = new Size(150, 50);
            btnViewTransactions.Location = new Point(190, 50);
            btnViewTransactions.BackColor = Color.White;

            panelOverlay.Controls.Add(btnViewProperties);
            panelOverlay.Controls.Add(btnViewOwners);
            panelOverlay.Controls.Add(btnViewTransactions);

            this.Controls.Add(panelOverlay);

            this.Resize += (s, e) => CenterButtons(panelOverlay, btnViewProperties, btnViewOwners, btnViewTransactions);
            CenterButtons(panelOverlay, btnViewProperties, btnViewOwners, btnViewTransactions);

            btnViewProperties.Click += btnViewProperties_Click;
            btnViewOwners.Click += btnViewOwners_Click;
            btnViewTransactions.Click += btnViewTransactions_Click;
        }

        private void CenterButtons(Panel panel, Button btn1, Button btn2, Button btn3)
        {
            int formWidth = panel.Width;
            int buttonSpacing = 25;
            int totalButtonWidth = btn1.Width + btn2.Width + btn3.Width + (2 * buttonSpacing);
            int startX = (formWidth - totalButtonWidth) / 2;

            btn1.Location = new Point(startX, panel.Height / 2 - btn1.Height / 2);
            btn2.Location = new Point(startX + btn1.Width + buttonSpacing, panel.Height / 2 - btn2.Height / 2);
            btn3.Location = new Point(startX + btn1.Width + btn2.Width + 2 * buttonSpacing, panel.Height / 2 - btn3.Height / 2);
        }
        private void btnViewProperties_Click(object sender, EventArgs e)
        {
            PropertyManagement propertyForm = new PropertyManagement();
            propertyForm.Show();
        }

        private void btnViewOwners_Click(object sender, EventArgs e)
        {
            Owner_Management ownerForm = new Owner_Management();
            ownerForm.Show();
        }

        private void btnViewTransactions_Click(object sender, EventArgs e)
        {
            TransactionManagement transactionForm = new TransactionManagement();
            transactionForm.Show();
        }
    }
}
