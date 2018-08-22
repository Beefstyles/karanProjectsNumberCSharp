using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaranNumberProjects
{
    class DiceRoller
    {
        public static void DiceRollerLoad()
        {
            Random rnd = new Random();
            for (int i = 0; i < 1000; i++)
            {
                ReturnDiceRoll("100d100", rnd);
            }
            Console.ReadKey();
        }

        private static int ReturnDiceRoll(string diceInformation, Random rnd)
        {
            int numberOfDice = Convert.ToInt32(diceInformation.Substring(0, diceInformation.IndexOf("d")));
            int sidesOfDice = Convert.ToInt32(diceInformation.Split('d').Last());
            int diceTotal = 0;
            
            for (int i = 1; i <= numberOfDice; i++)
            {
                diceTotal += rnd.Next(1, sidesOfDice + 1);
            }
            Console.WriteLine("Rolled {0} and returned {1}", diceInformation, diceTotal);
            return diceTotal;
        }
    }
}
