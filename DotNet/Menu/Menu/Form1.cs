namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void homeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void aboutUsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome to McDonald";
            label1.Font = new Font(label1.Font, FontStyle.Bold);
            label1.Font = new Font(label1.Font.FontFamily, 32);
            label1.ForeColor = Color.Red;
        }
    }
}