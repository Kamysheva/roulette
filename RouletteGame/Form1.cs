using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static RouletteGame.Program;

namespace RouletteGame
{
    public partial class Form1 : Form
    {
        private static Gamer player = new Gamer("Игрок",1000);
        private Dealer dealer = new Dealer(1000000, new List<Gamer> {player});
        private Group[] groups = new Group[] {
        new Group("redBet",
            new int[]{
                1,3,5,7,9,12,14,16,18,19,21,23,25,27,30,32,34,36
            },
            2),
        new Group("blackBet",
            new int[]{
                2,4,6,8,10,11,13,15,17,20,22,24,26,28,29,33,35
            },
            2),
        new Group("firstDozenBet",
            new int[]{
                1,2,3,4,5,6,7,8,9,10,11,12
            },
            3),
        new Group("secondDozenBet",
            new int[]{
                13,14,15,16,17,18,19,20,22,24
            },
            3),
        new Group("thirdDozenBet",
            new int[]{
                25,26,27,28,29,30,31,32,33,34,36
            },
            3),
        new Group("firstHalfBet",
            new int[]{
                1,2,3,4,5,6,7,8,9,10,11,12,14,16,17,18,
            },
            2),
        new Group("secondHalfBet",
            new int[]{
                19,20,22,24,25,26,27,28,29,30,31,32,33,34,36
            },
            2),
        new Group("oddBet",
            new int[]{
                1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35
            },
            2),
        new Group("evenBet",
            new int[]{
                2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36
            },
            2),
        };
        public Form1()
        {
            InitializeComponent();
            playerName.Text= player.Name;
            cash.Text="Cash: $" + player.Money;
            int[] straightNumbersArray = new int[36];
            for (int i = 0; i < 36; i++)
            {
                straightNumbersArray[i] = i + 1;
            }
            object[] objectArray = Array.ConvertAll(straightNumbersArray, x => (object)x);
            this.straightChoice.Items.AddRange(objectArray);
        }

        private void spinBtn_Click(object sender, EventArgs e)
        {
            
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is TextBox textBox)
                {
                    if (!string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        var currentGroup = groups.FirstOrDefault(group => group.Name == textBox.Name);
                        var currentBet = player.MakeBet(currentGroup, float.Parse(textBox.Text));
                        if(currentBet!=null)
                        {
                            int spinResult = dealer.Spin();
                            var winBet = dealer.CheckBets(spinResult, new Bet[] { currentBet });

                            infoTextBox.Text += "Ваша ставка - $" + textBox.Text + " на " + currentGroup.Name + "\n";
                            infoTextBox.Text += "На рулетке выпало " + spinResult + "\n";
                            if (winBet.Length > 0)
                            {
                                dealer.GiveWinnings(winBet);
                                infoTextBox.Text += "Победа! Вы выиграли $" + currentGroup.Payout * currentBet.Money + "\n";
                                cash.Text = "Cash: $" + player.Money;
                            }
                            else
                            {
                                infoTextBox.Text += "Проигрыш. Вы потеряли $" + currentBet.Money + "\n";
                                cash.Text = "Cash: $" + player.Money;
                            }
                        }
                        else 
                        {
                            infoTextBox.Text += "У вас не хватает денег на эту ставку " + "\n";
                        }
                        break;
                    }
                }
            }
            
            
        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            player = new Gamer("Игрок",1000);
            infoTextBox.Clear();
            cash.Text = "Cash: $" + player.Money;
        }
    }
}
