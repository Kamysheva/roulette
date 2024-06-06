using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RouletteGame.Program;

namespace RouletteGame
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public class Group
        {
            public string Name { get; set; }
            public int[] Numbers { get; set; }
            public int Payout { get; set; }
            //public int[] Location { get; set; }

            public Group(string name, int[] numbers, int payout) //int[] location
            {
                Name = name;
                Numbers = numbers;
                Payout = payout;
                //Location = location;
            }
        }
        public class Bet
        {
            public Group Group { get; set; }
            public float Money { get; set; }
            public string Gamer { get; set; }

            public Bet(Group group, float money, string gamer)
            {
                Group = group;
                Money = money;
                Gamer = gamer;
            }
        }
        public class Gamer
        {
            public string Name { get; set; }
            public float Money { get; set; }

            public Gamer(string name, float money)
            {
                Name = name;
                Money = money;
            }

            public Bet MakeBet(Group group, float money)
            {
                if (money <= Money)
                {
                    Money -= money;
                    return new Bet(group, money, this.Name);
                }
                else
                {
                    return null;
                }
            }
        }


    public class Dealer
        {
            public float Money { get; set; }
            public int RouletteSpinResult { get; set; }
            public List<Gamer> Gamers { get; set; }

            public Dealer(float money, List<Gamer> gamers)
            {
                Money = money;
                Gamers = gamers;
            }

            public int Spin()
            {
                Random random = new Random();
                RouletteSpinResult = random.Next(1, 37);
                return RouletteSpinResult;
            }

            public Bet[] CheckBets(int rouletteResult, Bet[] bets)
            {
                List<Bet> winningBets = new List<Bet>();

                foreach (Bet bet in bets)
                {
                    if (bet.Group.Numbers.Contains(rouletteResult))
                    {
                        winningBets.Add(bet);
                    }
                }

                return winningBets.ToArray();
            }

            public void GiveWinnings(Bet[] winningBets)
            {
                foreach (Bet bet in winningBets)
                {
                    foreach (Gamer gamer in this.Gamers)
                    {
                        if (gamer.Name == bet.Gamer)
                        {
                            float payout = bet.Group.Payout * bet.Money;
                            this.Money -= payout;
                            gamer.Money += payout;

                        }
                    }
                }
            }
        }

}
}
