using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginAndSignUp
{
    public partial class Form3 : Form
    {
        public Form3(string username)
        {
            InitializeComponent();
            greetings.Text = $"Hi, {username}!";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            welcomeMessage.Text = greetings.Text;
        }
    }
}
