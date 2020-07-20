using Game15Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _15game
{
    public partial class Form1 : Form
    {
        
        Game15 game;
        Button[] buttons;

        public Form1()
        {
            InitializeComponent();
            game = new Game15();
            buttons = new Button[16];

            buttons[0] = button1;            
            buttons[1] = button2;            
            buttons[2] = button3;            
            buttons[3] = button4;            
            buttons[4] = button5;            
            buttons[5] = button6;            
            buttons[6] = button7;            
            buttons[7] = button8;            
            buttons[8] = button9;            
            buttons[9] = button10;            
            buttons[10] = button11;            
            buttons[11] = button12;            
            buttons[12] = button13;            
            buttons[13] = button14;            
            buttons[14] = button15;            
            buttons[15] = button16;            

            setButtonsText();
            textBoxMoveCntr.Focus();
        }

        public void setButtonsText()
        {
            textBoxMoveCntr.Text = "" + game.cnt;
            for (int k = 0; k < 16; k++)
            {
                int i = k / 4;
                int j = k % 4;
                int val = game[i, j];
                //buttons[k].Text = (val == 0) ? " " : ""+val;
                if(val == 0)
                {
                    buttons[k].Text = " ";
                    buttons[k].Visible = false;
                    //buttons[k].BackColor = BackColor;
                }
                else
                {
                    buttons[k].Text = "" + val;
                    buttons[k].Visible = true;
                    //buttons[k].BackColor = Color.Aqua;
                }
            }
            textBoxMoveCntr.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idx = -1;
            for (int k = 0; k < 16; k++)
            {
                if (buttons[k] == (Button)sender) {
                    idx = k;
                    break;
                }
            }

            int i = idx / 4;
            int j = idx % 4;
            bool gameOver = game.turn(i,j);
            setButtonsText();

            if (gameOver)
            {
                MessageBox.Show("Game complete!");
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            game.reset();
            setButtonsText();

        }
    }
}
