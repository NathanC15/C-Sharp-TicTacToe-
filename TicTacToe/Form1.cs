using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int player = 2; //Even = X (Turn) //Odd = O (Turn)
        public int turns = 0; //Counts turns

        //Counting wins or draws for the players
        public int s1 = 0; //Score for player 1
        public int s2 = 0; //Score for player 2
        public int sd = 0; //Number of draws from both players

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "")
            {
                if (player % 2 == 0)
                {
                    button.Text = "X";
                    player++;
                    turns++;
                }
                else
                {
                    button.Text = "O";
                    player++;
                    turns++;
                }
                if ((CheckDraw() == true) && CheckWinner() == false)
                {
                    MessageBox.Show("Tie Game!");
                    sd++;
                    NewGame();
                }
                if(CheckWinner() == true)
                {
                    if (button.Text == "X")
                    {
                        MessageBox.Show("X Won!");
                        s1++;
                        NewGame();
                    }
                    else
                    {
                        MessageBox.Show("O Won!");
                        s2++;
                        NewGame();
                    }
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XWins.Text = "X Wins:" + s1;
            OWins.Text = "O Wins:" + s2;
            Draws.Text = "Draws:" + sd;

        }

        private void NGButton_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        void NewGame()
        {
            player = 2;
            turns = 0;
            TopLeft.Text = TopMiddle.Text = TopRight.Text = MiddleLeft.Text = Middle.Text = MiddleRight.Text = BottomLeft.Text = BottomMiddle.Text = BottomRight.Text = "";
            XWins.Text = "X Wins:" + s1;
            OWins.Text = "O Wins:" + s2;
            Draws.Text = "Draws:" + sd;
        }

        bool CheckDraw()
        {
            if (turns == 9)
                return true;
            else
                return false;
        }

        bool CheckWinner()
        {
            //Horizontal Checks (Top)
            if ((TopLeft.Text == TopMiddle.Text) && (TopMiddle.Text == TopRight.Text) && TopLeft.Text != "")
                return true;
            //Horizontal Checks (Middle) 
            else if ((MiddleLeft.Text == Middle.Text) && (Middle.Text == MiddleRight.Text) && MiddleLeft.Text != "")
                return true;
            //Horizontal Checks (Bottom)
            else if ((BottomLeft.Text == BottomMiddle.Text) && (BottomMiddle.Text == BottomRight.Text) && BottomLeft.Text != "")
                return true;

            //Vertical Checks (Left)
            if ((TopLeft.Text == MiddleLeft.Text) && (MiddleLeft.Text == BottomLeft.Text) && TopLeft.Text != "")
                return true;
            //Vertical Checks (Middle)
            else if ((TopMiddle.Text == Middle.Text) && (Middle.Text == BottomMiddle.Text) && TopMiddle.Text != "")
                return true;
            //Vertical Checks (Right)
            else if ((TopRight.Text == MiddleRight.Text) && (MiddleRight.Text == BottomRight.Text) && TopRight.Text != "")
                return true;

            //Diagonal Checks (Bottom Left to Top Right)
            if ((BottomLeft.Text == Middle.Text) && (Middle.Text == TopRight.Text) && BottomLeft.Text != "")
                return true;
            //Diagonal Checks (Top Left to Bottom Right)
            else if ((TopLeft.Text == Middle.Text) && (Middle.Text == BottomRight.Text) && TopLeft.Text != "")
                return true;
            else return false;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            s1 = s2 = sd = 0;
            NewGame();
        }
    }
}
