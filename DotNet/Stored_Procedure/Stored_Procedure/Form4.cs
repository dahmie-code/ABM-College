using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stored_Procedure
{
    public partial class Form4 : Form
    {
        private Dictionary<string, string> gradePosition;
        public Form4()
        {
            InitializeComponent();
            LoadInitialData();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            button1.Text = "Correct Position";
        }
        private void LoadInitialData()
        {
            dataGridView1.Columns.Add("S/N", "S/N");
            dataGridView1.Columns.Add("Grade", "Grade");
            dataGridView1.Columns.Add("Position", "Position");

            dataGridView1.Rows.Add("1", "B", "11th");
            dataGridView1.Rows.Add("2", "A", "6th");
            dataGridView1.Rows.Add("3", "C", "3rd");
            dataGridView1.Rows.Add("4", "D", "1st");
            dataGridView1.Rows.Add("5", "F", "2nd");
            dataGridView1.Rows.Add("6", "K", "4th");
        }

        private void CorrectPositions()
        {
            gradePosition = new Dictionary<string, string>()
            {
                { "A", "1st" },
                { "B", "2nd" },
                { "C", "3rd" },
                { "D", "4th" },
                { "F", "6th" },
                { "K", "11th" }
            };

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    string grade = row.Cells[1].Value.ToString();
                    if (gradePosition.ContainsKey(grade))
                    {
                        row.Cells[2].Value = gradePosition[grade];
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CorrectPositions();
        }
    }
}
