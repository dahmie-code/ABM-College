using Microsoft.VisualBasic;

namespace DateManipulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toDate.Text = "To Date";
            fromDate.Text = "From Date";
            result.Text = "";
            button1.Text = "Submit";

            label1.Text = "Calculate your birthday";
            label2.Text = "";

            label3.Text = "Country";

            string[] coutries = { "--Choose Country--", "China", "USA", "France", "Australia" };
            comboBox1.Items.AddRange(coutries);
            comboBox1.SelectedIndex = 0;

            label4.Text = "";
            label5.Text = "";

            dateTimePicker5.CustomFormat = " ";
            dateTimePicker5.Format = DateTimePickerFormat.Custom;


        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateOnly dateTo = DateOnly.Parse(dateTimePicker1.Text);
            DateOnly fromDate = DateOnly.Parse(dateTimePicker2.Text);

            TimeSpan diff = dateTo.ToDateTime(TimeOnly.MinValue) - fromDate.ToDateTime(TimeOnly.MinValue);


            result.Text = $"The differnce between the two dates is {diff.TotalHours} hours";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dateCalc = dateTimePicker3.Text;
            DateTime date = DateTime.Parse(dateCalc);
            string day = date.DayOfWeek.ToString();
            label2.Text = day;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker4.Value;
            string newDate = date.ToString("d, MMMM yyyy h:mm:ss tt");
            label4.Text += newDate;

        }
        private void dateTimePicker5_ValueChanged(object sender, EventArgs e)
        {

            try
            {
                dateTimePicker5.CustomFormat = "dddd, MMMM dd, yyyy h:mm:ss tt";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateTimePicker5.CustomFormat == " ")
                {
                    label5.Text = "You have not selected any date, please choose a date.";
                }
                else
                {
                 
                    DateTime selectedDate = dateTimePicker5.Value;
                    label5.Text = "Selected Date: " + selectedDate.ToString("dddd, MMMM dd, yyyy h:mm:ss tt");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}