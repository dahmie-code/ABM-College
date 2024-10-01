using System.Windows.Forms;

namespace Second_HandPhone_Sale_App
{
    public partial class Form1 : Form
    {
        private string user;
        private Dictionary<int, string[]> userData; 
        private int userId;
        private string userContact;
        public Form1()
        {
            InitializeComponent();
            pictureBoxBanner.Paint += new PaintEventHandler(pictureBoxBanner_Paint);
            userData = new Dictionary<int, string[]>();
            userId = 1;
            userContact = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bannerText.Text = "@phoneBazaar2024";
            bannerText.Font = new Font(bannerText.Font, FontStyle.Italic);


        }

        private void pictureBoxBanner_Paint(object sender, PaintEventArgs e)
        {

            Color overlayColor = Color.FromArgb(128, 0, 0, 0);
            using (SolidBrush brush = new SolidBrush(overlayColor))
            {
                e.Graphics.FillRectangle(brush, pictureBoxBanner.ClientRectangle);
            }


            string welcomeText = "Welcome to PhoneBazaar";
            Font welcomeFont = new Font("Arial", 36, FontStyle.Bold);
            Color textColor = Color.White;

            SizeF welcomeTextSize = e.Graphics.MeasureString(welcomeText, welcomeFont);
            PointF welcomeTextPosition = new PointF(
                (pictureBoxBanner.Width - welcomeTextSize.Width) / 2,
                (pictureBoxBanner.Height / 4) - (welcomeTextSize.Height / 2)
            );

            using (SolidBrush textBrush = new SolidBrush(textColor))
            {
                e.Graphics.DrawString(welcomeText, welcomeFont, textBrush, welcomeTextPosition);
            }


            string sloganText = "Your Trusted Marketplace for Quality Second-Hand Phones";
            Font sloganFont = new Font("Arial", 24, FontStyle.Bold);

            SizeF sloganTextSize = e.Graphics.MeasureString(sloganText, sloganFont);
            PointF sloganTextPosition = new PointF(
                (pictureBoxBanner.Width - sloganTextSize.Width) / 2,
                (pictureBoxBanner.Height / 2) + (welcomeTextSize.Height / 2) + 20
            );

            using (SolidBrush textBrush = new SolidBrush(textColor))
            {
                e.Graphics.DrawString(sloganText, sloganFont, textBrush, sloganTextPosition);
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (user != null && userData != null)
            {
                Home homeForm = new Home(user, userData, userId, userContact);
                homeForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("User or user data is not set properly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buyPhonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kindly Login to buy a phone","Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sellPhonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kindly Login to buy a phone", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void registerLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login LoginForm = new Login();
            LoginForm.ShowDialog();
        }
    }
}