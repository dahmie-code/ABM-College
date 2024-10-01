namespace Class_day2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Submit";
            textBox1.Text = "Damie";
            checkBox1.Checked = false;
            radioButton1.Checked = false;
            checkBox2.Text = "M";
            checkBox3.Text = "F";
            checkBox2.CheckState = CheckState.Unchecked;
            checkBox3.CheckState = CheckState.Unchecked;

        }

        private void Form1_Move(object sender, EventArgs e)
        {
            button1.Text = "Damie";
            //checkBox1.Checked = !checkBox1.Checked;
            radioButton1.Checked = true;
            if (checkBox1.Checked == true)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabels();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabels();
        }
        private void UpdateLabels()
        {
            if (checkBox2.Checked && checkBox3.Checked)
            {
                label3.Text = "Both Male and Female are selected";
                label1.Text = "";
                label2.Text = "";
            }
            else
            {
                label3.Text = "";
                if (checkBox2.Checked)
                {
                    label1.Text = "Male is selected";
                }
                else
                {
                    label1.Text = "";
                }

                if (checkBox3.Checked)
                {
                    label2.Text = "Female is selected";
                }
                else
                {
                    label2.Text = "";
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}