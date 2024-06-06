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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RouletteGame
{
    public partial class Form1 : Form
    {
        //private string currentTime = DateTime.Now.ToString("HH:mm:ss tt");
        private Bet[] allBets = new Bet[] { };
        private int currentFishka = 10;
        private static Gamer player = new Gamer("Игрок", 1000);
        private Dealer dealer = new Dealer(1000000, new List<Gamer> {player});
        private Group[] groups = new Group[] {
        new Group("straightBet",//0
            new int[]{
                1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,22,24,25,26,27,28,29,30,31,32,33,34,35,36
            },
            2),
        new Group("redBet",//1
            //location 472; 177
            new int[]{
                1,3,5,7,9,12,14,16,18,19,21,23,25,27,30,32,34,36
            },
            2),
        new Group("blackBet",//2
            //location 472; 237
            new int[]{
                2,4,6,8,10,11,13,15,17,20,22,24,26,28,29,33,35
            },
            2),
        new Group("firstDozenBet",//3
            //location 506; 60
            new int[]{
                1,2,3,4,5,6,7,8,9,10,11,12
            },
            3),
        new Group("secondDozenBet",//4
            //location 506; 173
            new int[]{
                13,14,15,16,17,18,19,20,22,24
            },
            3),
        new Group("thirdDozenBet",//5
            //location 506; 280
            new int[]{
                25,26,27,28,29,30,31,32,33,34,36
            },
            3),
        new Group("firstHalfBet",//6
            //location 472; 60
            new int[]{
                1,2,3,4,5,6,7,8,9,10,11,12,14,16,17,18,
            },
            2),
        new Group("secondHalfBet",//7
            //location 472; 337
            new int[]{
                19,20,22,24,25,26,27,28,29,30,31,32,33,34,36
            },
            2),
        new Group("oddBet",//8
            //location 472; 280
            new int[]{
                1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35
            },
            2),
        new Group("evenBet",//9
            //location 472; 120
            new int[]{
                2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36
            },
            2),
            //new int[]{472, 120}),
        };
        public Form1()
        {
            
            InitializeComponent();
            cash.Text="Ваш счет: $" + player.Money;
            int[] straightNumbersArray = new int[36];
            for (int i = 0; i < 36; i++)
            {
                straightNumbersArray[i] = i + 1;
            }
            object[] objectArray = Array.ConvertAll(straightNumbersArray, x => (object)x);
            //this.straightChoice.Items.AddRange(objectArray);
        }

        private void spinBtn_Click(object sender, EventArgs e)
        {
            if (allBets.Length != 0)
            {
                if(allBets.Contains(null))
                {
                    MessageBox.Show("У вас не хватает денег на эту ставку");
                }
                else
                {
                    int spinResult = dealer.Spin();
                    var winBet = dealer.CheckBets(spinResult, allBets);

                    //infoTextBox.Text += currentTime+"Ваша ставка - $" + textBox.Text + " на " + currentGroup.Name + "\n";
                    rouletteResult.Text += spinResult + "\n";
                    if (winBet.Length > 0)
                    {
                        dealer.GiveWinnings(winBet);
                        MessageBox.Show(
                            "На рулетке выпало " + spinResult + "\n" +
                            "Победа!");
                        cash.Text = "Ваш счет: $" + player.Money;
                    }
                    else
                    {
                        MessageBox.Show(
                            "На рулетке выпало" + spinResult + "\n" +
                            "Проигрыш.");
                        cash.Text = "Ваш счет: $" + player.Money;
                    }
                }
            }
            else
            {
                MessageBox.Show("Сделайте ставку");
            }
            allBets = new Bet[] { };
            allBetsDisplay.Clear();
        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            player = new Gamer("Игрок",1000);
            allBets = new Bet[] { };
            allBetsDisplay.Clear();
            rouletteResult.Clear();
            cash.Text = "Ваш счет: $" + player.Money;
        }

        private void fishka10_Click(object sender, EventArgs e)
        {
            currentFishka = 10;
        }

        private void fishka50_Click(object sender, EventArgs e)
        {
            currentFishka = 50;
        }

        private void fishka100_Click(object sender, EventArgs e)
        {
            currentFishka = 100;
        }

        private void fishka500_Click(object sender, EventArgs e)
        {
            currentFishka = 500;
        }

        private void fishka1000_Click(object sender, EventArgs e)
        {
            currentFishka = 1000;
        }

        private void btn1to18_Click(object sender, EventArgs e)
        {
            allBetsDisplay.Text += currentFishka + " на \"с 1 по 18\"" + "\n";
            allBets = allBets.Append(player.MakeBet(groups[3], currentFishka)).ToArray();
        }

        private void btnEven_Click(object sender, EventArgs e)
        {
            allBetsDisplay.Text += currentFishka + " на \"Четные\"" + "\n";
            allBets = allBets.Append(player.MakeBet(groups[9], currentFishka)).ToArray();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            allBetsDisplay.Text += currentFishka + " на \"Красные\"" + "\n";
            allBets = allBets.Append(player.MakeBet(groups[1], currentFishka)).ToArray();
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            allBetsDisplay.Text += currentFishka + " на \"Черные\"" + "\n";
            allBets = allBets.Append(player.MakeBet(groups[2], currentFishka)).ToArray();
        }

        private void btnOdd_Click(object sender, EventArgs e)
        {
            allBetsDisplay.Text += currentFishka + " на \"Нечетные\"" + "\n";
            allBets = allBets.Append(player.MakeBet(groups[8], currentFishka)).ToArray();
        }

        private void btn19to36_Click(object sender, EventArgs e)
        {
            allBetsDisplay.Text += currentFishka + " на \"c 19 по 36\"" + "\n";
            allBets = allBets.Append(player.MakeBet(groups[7], currentFishka)).ToArray();
        }

        private void btn1st12_Click(object sender, EventArgs e)
        {
            allBetsDisplay.Text += currentFishka + " на \"Первая дюжина\"" + "\n";
            allBets = allBets.Append(player.MakeBet(groups[3], currentFishka)).ToArray();
        }

        private void btn2nd12_Click(object sender, EventArgs e)
        {
            allBetsDisplay.Text += currentFishka + " на \"Вторая дюжина\"" + "\n";
            allBets = allBets.Append(player.MakeBet(groups[4], currentFishka)).ToArray();
        }

        private void btn3rd12_Click(object sender, EventArgs e)
        {
            allBetsDisplay.Text += currentFishka + " на \"Третья дюжина\"" + "\n";
            allBets = allBets.Append(player.MakeBet(groups[5], currentFishka)).ToArray();
        }

        private void btn3rdRow_Click(object sender, EventArgs e)
        {
            //allBetsDisplay.Text += currentFishka + " на \"c 19 по 36\"" + "\n";
            //var newBet = player.MakeBet(groups[7], currentFishka);
        }

        private void btn2ndRow_Click(object sender, EventArgs e)
        {
            //allBetsDisplay.Text += currentFishka + " на \"c 19 по 36\"" + "\n";
            //var newBet = player.MakeBet(groups[7], currentFishka);
        }

        private void btn1stRow_Click(object sender, EventArgs e)
        {
            //allBetsDisplay.Text += currentFishka + " на \"c 19 по 36\"" + "\n";
            //var newBet = player.MakeBet(groups[7], currentFishka);
        }
    }
}
