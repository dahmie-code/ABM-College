using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectionManipulation
{
    public partial class Form2 : Form
    {
        Button[,] btns = new Button[4, 4];

        public void initialise()
        {
            button1.Text = string.Empty;
            button2.Text = string.Empty;
            button3.Text = string.Empty;
            button4.Text = string.Empty;
            button5.Text = string.Empty;    
            button6.Text = string.Empty;
            button7.Text = string.Empty;
            button8.Text = string.Empty;
            button9.Text = string.Empty;
            score_0.Text = string.Empty;
            score_X.Text = string.Empty;
            rnd_no.Text = string.Empty;

            btns[1, 1] = button1;
            btns[1, 2] = button2;
            btns[1, 3] = button3;
            btns[2, 1] = button4;
            btns[2, 2] = button5;
            btns[2, 3] = button6;
            btns[3, 1] = button7;
            btns[3, 2] = button8;
            btns[3, 3] = button9;

        }

        int rnd_count = 1;
        int btn_count = 1;
        string symbol;
        int win_count_0 = 0;
        int win_count_X = 0;
        int flag = 0;
        public Form2()
        {
            InitializeComponent();
            initialise();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            initialise();
        }

        private void turn_decider()
        {
            if (btn_count % 2 == 0)
            {
                symbol = "O";
            }
            else
            {
                symbol = "X";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            turn_decider();
            button1.Text = symbol;
            btn_count++;
            button1.Enabled = false;
            if (btn_count >= 5)
            {
                check_winner(1, 1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            turn_decider();
            button2.Text = symbol;
            btn_count++;
            button2.Enabled = false;
            if (btn_count >= 5)
            {
                check_winner(1, 2);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            turn_decider();
            button3.Text = symbol;
            btn_count++;
            button3.Enabled = false;
            if (btn_count >= 5)
            {
                check_winner(1, 3);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            turn_decider();
            button4.Text = symbol;
            btn_count++;
            button4.Enabled = false;
            if (btn_count >= 5)
            {
                check_winner(2, 1);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            turn_decider();
            button5.Text = symbol;
            btn_count++;
            button5.Enabled = false;
            if (btn_count >= 5)
            {
                check_winner(2, 2);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            turn_decider();
            button6.Text = symbol;
            btn_count++;
            button6.Enabled = false;
            if (btn_count >= 5)
            {
                check_winner(2, 3);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            turn_decider();
            button7.Text = symbol;
            btn_count++;
            button7.Enabled = false;
            if (btn_count >= 5)
            {
                check_winner(3, 1);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            turn_decider();
            button8.Text = symbol;
            btn_count++;
            button8.Enabled = false;
            if (btn_count >= 5)
            {
                check_winner(3, 2);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            turn_decider();
            button9.Text = symbol;
            btn_count++;
            button9.Enabled = false;
            if (btn_count >= 5)
            {
                check_winner(3, 3);
            }
        }
public void check_winner(int row, int col)
{
    bool winnerFound = false;

    if (btns[row, col].Text == "O")
    {
        for (int i = 1; i <= 3; i++)
        {
            if (btns[i, 1].Text == "O" && btns[i, 2].Text == "O" && btns[i, 3].Text == "O")
            {
                winnerFound = true;
            }
            if (btns[1, i].Text == "O" && btns[2, i].Text == "O" && btns[3, i].Text == "O")
            {
                winnerFound = true;
            }
        }
        if (btns[1, 1].Text == "O" && btns[2, 2].Text == "O" && btns[3, 3].Text == "O")
        {
            winnerFound = true;
        }
        if (btns[1, 3].Text == "O" && btns[2, 2].Text == "O" && btns[3, 1].Text == "O")
        {
            winnerFound = true;
        }

        if (winnerFound)
        {
            MessageBox.Show("O is the Winner of this round ");
            win_count_0++;
            necessary_calculations();
            clear();
            return;
        }
    }

    if (btns[row, col].Text == "X")
    {
        for (int i = 1; i <= 3; i++)
        {
            if (btns[i, 1].Text == "X" && btns[i, 2].Text == "X" && btns[i, 3].Text == "X")
            {
                winnerFound = true;
            }
            if (btns[1, i].Text == "X" && btns[2, i].Text == "X" && btns[3, i].Text == "X")
            {
                winnerFound = true;
            }
        }
        if (btns[1, 1].Text == "X" && btns[2, 2].Text == "X" && btns[3, 3].Text == "X")
        {
            winnerFound = true;
        }
        if (btns[1, 3].Text == "X" && btns[2, 2].Text == "X" && btns[3, 1].Text == "X")
        {
            winnerFound = true;
        }

        if (winnerFound)
        {
            MessageBox.Show("X is the Winner of this round ");
            win_count_X++;
            necessary_calculations();
            clear();
            return;
        }
    }

    if (btn_count > 9 && !winnerFound)
    {
        MessageBox.Show("This round is a draw.");
        necessary_calculations();
        clear();
    }
}

        public void necessary_calculations()
        {
            if (rnd_count >= 3)
            {
                check_finalWinner();
            }

            rnd_count++;

            if (rnd_count > 5 && (win_count_0 == win_count_X))
            {
                if (flag == 1)
                {
                    DialogResult ok = MessageBox.Show("The super round is also a draw. \nTry again next time.", "DRAW", MessageBoxButtons.OK);
                    MessageBox.Show("GAME OVER \n☺ THANKS FOR PLAYING ☺");
                    if (ok == DialogResult.OK)
                    {
                        System.Windows.Forms.Application.Exit();
                    }
                }
                else
                {
                    DialogResult ok = MessageBox.Show("Both the players has same score. \nFinal result will be decided by playing a super round", "DRAW", MessageBoxButtons.OK);
                    string draw = "0";
                    rnd_no.Text = draw.ToString();
                    flag = 1;
                }
            }
            else
            {
                rnd_no.Text = rnd_count.ToString();
            }

            btn_count = 1;
            score_X.Text = win_count_X.ToString();
            score_0.Text = win_count_0.ToString();
        }
        public void clear()
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    btns[i, j].Text = " ";
                    btns[i, j].Enabled = true;
                }
            }
        }
        public void check_finalWinner()
        {
            if (win_count_X >= 3 || (flag == 1 && win_count_X > win_count_0))
            {
                DialogResult ok = MessageBox.Show("X IS THE FINAL CHAMPION.", "FINAL RESULT", MessageBoxButtons.OK);
                MessageBox.Show("GAME OVER \n☺ THANKS FOR PLAYING ☺");
                if (ok == DialogResult.OK)
                {
                    System.Windows.Forms.Application.Exit();
                }
            }
            else if (win_count_0 >= 3 || (flag == 1 && win_count_0 > win_count_X))
            {
                DialogResult ok = MessageBox.Show("O IS THE FINAL CHAMPION.", "FINAL RESULT", MessageBoxButtons.OK);
                MessageBox.Show("GAME OVER \n☺ THANKS FOR PLAYING ☺");
                if (ok == DialogResult.OK)
                {
                    System.Windows.Forms.Application.Exit();
                }
            }
        }
    }
}
