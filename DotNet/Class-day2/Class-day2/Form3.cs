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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            label1.Text = "Username:";
            label2.Text = "Password:";
            label3.AutoSize = false;
            label3.Width = 100;
            label3.Height = 100;
            label3.Text = "City of \nEmployment:";
            label4.Text = "Webserver";
            label5.AutoSize = false;
            label5.Width = 150;
            label5.Height = 100;
            label5.Text = "Please specify \nyour role:";
            label6.AutoSize = false;
            label6.Width = 150;
            label6.Height = 100;
            label6.Text = "Single Sign-on \nto the following";
            label7.Text = "Novell Services Login";

            comboBox1.Text = "--Choose a server--";
            string[] webServer = { "Development", "Sales", "Human Resources", };
            comboBox1.Items.AddRange(webServer);

            radioButton1.Text = "Admin";
            radioButton1.Checked = false;
            radioButton2.Text = "Engineer";
            radioButton2.Checked = false;
            radioButton3.Text = "Manager";
            radioButton3.Checked = false;
            radioButton4.Text = "Guest";
            radioButton4.Checked = false;

            checkBox1.Text = "Mail";
            checkBox1.Checked = false;
            checkBox2.Text = "Payroll";
            checkBox2.Checked = false;
            checkBox3.Text = "Self-service";
            checkBox3.Checked = false;

            button1.Text = "Login";

            InitializeErrorLabels();
        }
        private void InitializeErrorLabels()
        {
            Label[] errorLabels = { labelErrorUsername, labelErrorPassword, labelErrorCity, labelErrorWebserver, labelErrorRole, labelErrorSignon };
            foreach (var errorLabel in errorLabels)
            {
                errorLabel.ForeColor = Color.Red;
                errorLabel.Visible = false;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            labelErrorUsername.Visible = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            labelErrorUsername.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            labelErrorPassword.Visible = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            labelErrorCity.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelErrorWebserver.Visible = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            bool isvalid = ValidateFields();
            if (isvalid)
            {
                string role = SelectedRole();
                string signOn = SelectedSignOn();

                string message = $"{textBox1.Text}\n" +
                                 $"{textBox2.Text}\n" +
                                 $"{textBox3.Text}\n" +
                                 $"{comboBox1.SelectedItem}\n" +
                                 $"{role}\n" +
                                 $"{signOn}\n";

                MessageBox.Show(message, "Form Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ValidateFields()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                labelErrorUsername.Text = "* Username is required";
                labelErrorUsername.Visible = true;
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                labelErrorPassword.Text = "* Password is required";
                labelErrorPassword.Visible = true;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                labelErrorCity.Text = "* City is required";
                labelErrorCity.Visible = true;
                isValid = false;
            }

            if (comboBox1.SelectedIndex == -1 || comboBox1.Text == "--Choose a server--")
            {
                labelErrorWebserver.Text = "* Please select a webserver!";
                labelErrorWebserver.Visible = true;
                isValid = false;
            }
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                labelErrorRole.Text = "* Please select a role";
                labelErrorRole.Visible = true;
                isValid = false;
            }
            if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked)
            {
                labelErrorSignon.Text = "* Please select at least one sign on";
                labelErrorSignon.Visible = true;
                isValid = false;
            }

            return isValid;

        }

        private string SelectedRole()
        {
            if (radioButton1.Checked) return radioButton1.Text;
            if (radioButton2.Checked) return radioButton2.Text;
            if (radioButton3.Checked) return radioButton3.Text;
            if (radioButton4.Checked) return radioButton4.Text;
            return "No role Selected";
        }

        private string SelectedSignOn()
        {
            List<string> selectedServices = new List<string>();
            if (checkBox1.Checked) selectedServices.Add(checkBox1.Text);
            if (checkBox2.Checked) selectedServices.Add(checkBox2.Text);
            if (checkBox3.Checked) selectedServices.Add(checkBox3.Text);
            return selectedServices.Count > 0 ? string.Join(", ", selectedServices) : "No services selected";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            labelErrorRole.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            labelErrorRole.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            labelErrorRole.Visible = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            labelErrorRole.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {labelErrorSignon.Visible = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            labelErrorSignon.Visible = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            labelErrorSignon.Visible = false;
        }
    }
}
