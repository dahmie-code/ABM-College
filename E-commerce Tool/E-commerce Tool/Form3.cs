using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_commerce_Tool
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            LoadBannerImage();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome to ShopSmart, We offer 10% off every Item";
            label1.Font = new Font(label1.Font, FontStyle.Bold);
            label1.Font = new Font(label1.Font.FontFamily, 36);
            label1.ForeColor = Color.White;
            label1.BackColor = Color.Black;
            homeToolStripMenuItem.Font = new Font(homeToolStripMenuItem.Font, FontStyle.Bold);
            homeToolStripMenuItem.Font = new Font(homeToolStripMenuItem.Font.FontFamily, 15);
            aboutUsToolStripMenuItem.Font = new Font(aboutUsToolStripMenuItem.Font, FontStyle.Bold);
            aboutUsToolStripMenuItem.Font = new Font(aboutUsToolStripMenuItem.Font.FontFamily, 15);
            loginRegisterToolStripMenuItem.Font = new Font(loginRegisterToolStripMenuItem.Font, FontStyle.Bold);
            loginRegisterToolStripMenuItem.Font = new Font(loginRegisterToolStripMenuItem.Font.FontFamily, 15);
        }
        private async void LoadBannerImage()
        {
            using (HttpClient client = new HttpClient())
            {

                byte[] imageData = await client.GetByteArrayAsync("https://images.unsplash.com/photo-1633926248455-d729718e0886?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D");


                using (MemoryStream stream = new MemoryStream(imageData))
                {

                    pictureBoxBanner.Image = Image.FromStream(stream);
                    pictureBoxBanner.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxBanner.Dock = DockStyle.Fill;
                }
            }
        }


        private void loginRegisterToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void aboutUsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }
    }
}
