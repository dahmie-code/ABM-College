using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_day2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label4.Text = "User Input";
            label11.Text = "";
            //int myAge = 13;
            //label1.Text = myAge.ToString();
            string name1 = funcPrintMyName();
            label1.Text = name1;

            int mean = funcMean();
            label2.Text = mean.ToString();
            label3.Text = "The mean value is:";

            textBox1.Text.ToString();

            string grades = funcGrades();
            label6.Text = grades;

            label7.Text = "Name";
            label8.Text = "Age";
            label9.Text = "Grade";
            label10.Text = "Gender";
            comboBox1.Text = "Grade";
            comboBox2.Text = "Gender";
            string[] grade = { "A", "B", "C" };
            comboBox1.Items.AddRange(grade);
            string[] gender = { "Male", "Female" };
            comboBox2.Items.AddRange(gender);

            button2.Text = "Submit";
            button3.Text = "OK";

        }
        public string funcPrintMyName()
        {
            string name = "Damie";
            return name;
        }

        public int funcMean()
        {
            int a = 6;
            int b = 4;
            int c = 3;
            int d = 6;
            int e = 6;
            int sum = a + b + c + d + e;
            int mean = sum / 5;
            return mean;
        }

        public bool funcMobile()
        {

            if (textBox1.Text.Length == 10)
            {
                return true;
            }
            return false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (funcMobile())
            {
                label5.Text = "Yes, the mobile number is correct.";
            }
            else
            {
                label5.Text = "This mobile number is incorrect.";
            }
        }
        public string funcGrades()
        {
            string subject1 = "English";
            string subject2 = "Math";

            char grade1 = 'A';
            char grade2 = 'B';

            string grades = $"Grades:\n" +
                            $"{subject1}: {grade2}\n" +
                            $"{subject2}: {grade1}";
            return grades;
        }

        public string funcBio()
        {
            char gradeMath = char.Parse(comboBox1.Text);
            string name = textBox2.Text;
            string age = textBox3.Text;
            string gender = comboBox2.SelectedItem?.ToString() ?? "Unknown";

            string message = $"My name is {name} and I am {age} years old and I have a grade of {gradeMath} in Maths, and I am a {gender}";


            return message;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string message = funcBio();

            MessageBox.Show(message);
        }

        public bool funcPalindrome()
        {
            string originalStr = textBox4.Text;
            char[] palindromeArr = originalStr.ToCharArray();
            Array.Reverse(palindromeArr);
            string revStr = new string(palindromeArr);

            return originalStr.Equals(revStr, StringComparison.OrdinalIgnoreCase);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool isPali = funcPalindrome();
            if (!isPali)
            {
                label11.Text = "No it's not a Palindrome";
            }
            else
            {
                label11.Text = "Yay! It's a Palindrome"; 
            }
        }
    }
}
