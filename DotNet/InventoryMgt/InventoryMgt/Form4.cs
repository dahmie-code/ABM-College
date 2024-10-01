using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMgt
{
    public partial class Form4 : Form
    {
        private int count = 0;
        private string sentence = "My name is Basant Gera and I teach at ABM College. My name is Kyle and I teach at ABM College...";
        private string inputString = "a;b;c;d;e;f;g!!o!7@g";
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Text = count.ToString();
            lblError.Text = "";
            label2.Text = "E-mail";
            btnSubmit.Text = "Submit";
            btnCount.Text = "Count Words";
            sentenceLabel.Text = sentence;
            lblWordPunctuationResult.Text = "";
            lblCharacterResult.Text = "";
            btnfilter.Text = "Filter";
            lblResult.Text = "";
            label3.Text = inputString;
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            //count++;
            //label1.Text = count.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            if (IsValidEmail(email))
            {
                lblError.Text = "Email is valid.";
                lblError.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblError.Text = "Invalid email format. Please enter a valid email.";
                lblError.ForeColor = System.Drawing.Color.Red;
                lblError.Font = new System.Drawing.Font(lblError.Font, System.Drawing.FontStyle.Italic);
            }
        }

        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            UpdateCounts();
        }
        private void UpdateCounts()
        {
            var wordPunctuationCounts = CountWordsAndPunctuation(sentence);
            var characterCounts = CountCharacters(sentence);

            string wordPunctuationResult = "Word counts:\n";
            foreach (var i in wordPunctuationCounts)
            {
                wordPunctuationResult += $"{i.Key}: {i.Value}\n";
            }
            lblWordPunctuationResult.Text = wordPunctuationResult;

            string characterResult = "Alphabet counts:\n";
            foreach (var i in characterCounts)
            {
                characterResult += $"{i.Key}: {i.Value}\n";
            }
            lblCharacterResult.Text = characterResult;
        }

        private Dictionary<string, int> CountWordsAndPunctuation(string sentence)
        {
            string[] words = sentence.ToLower().Split(new char[] { ' ', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                    counts[word] = 1;
                }
            }

            foreach (char c in sentence)
            {
                if (".,;!?".Contains(c))
                {
                    string punctuation = c.ToString();
                    if (counts.ContainsKey(punctuation))
                    {
                        counts[punctuation]++;
                    }
                    else
                    {
                        counts[punctuation] = 1;
                    }
                }
            }

            return counts;
        }

        private Dictionary<string, int> CountCharacters(string sentence)
        {
            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (char c in sentence.ToLower())
            {
                if (char.IsLetter(c))
                {
                    string character = c.ToString();
                    if (counts.ContainsKey(character))
                    {
                        counts[character]++;
                    }
                    else
                    {
                        counts[character] = 1;
                    }
                }
            }

            return counts;
        }

        private void btnfilter_Click(object sender, EventArgs e)
        {
            UpdateFilteredResult();
        }
        private void UpdateFilteredResult()
        {
            string result = FilterString(inputString);
            lblResult.Text = result;
        }
        private string FilterString(string input)
        {
            var filteredChars = input.Where(c => char.IsLetter(c) || c == '&');
            return new string(filteredChars.ToArray());
        }
    }
}
