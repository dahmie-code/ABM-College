namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello Damie!This is my first Project on .Net";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text;
        }
    }
}