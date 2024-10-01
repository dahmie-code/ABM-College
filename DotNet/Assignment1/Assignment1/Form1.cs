namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            sr.WriteLine("1 - Move event");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sr.WriteLine("2 - Load event");
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            sr.WriteLine("3 - VisibleChanged event");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            sr.WriteLine("4 - Activated event");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            sr.WriteLine("5 - Shown event");
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            sr.WriteLine("6 -  Paint event");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            sr.WriteLine("8 - FormClosing event");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            sr.WriteLine("9 - FormClosed event");
        }
        private void Form1_Deactivate(object sender, EventArgs e)
        {
            sr.WriteLine("7 - Deactivate event");
        }
    }
}