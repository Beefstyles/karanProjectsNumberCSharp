using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaranNumberProjects
{
    class CreditCardChecker
    {
        public static void CreditCardChecksum()
        {
            bool correctCreditCardNumberInput = false;
            bool viableNumber = false;
            long ccNumber = 0;

            while (!correctCreditCardNumberInput)
            {
                Console.WriteLine("Please enter a credit card number");
                if (long.TryParse(Console.ReadLine(), out ccNumber) && ccNumber > 0)
                {
                    correctCreditCardNumberInput = true;
                    viableNumber = CheckCCNumber(ccNumber);
                }
                else
                {
                    Console.WriteLine("Please enter a credit card number");
                }
            }

            if (correctCreditCardNumberInput)
            {
                Console.WriteLine("Credit Card Number of {0} is a viable number");
            }
            else
            {
                Console.WriteLine("Credit Card Number of {0} is not a viable number");
            }
            Console.ReadKey();
        }

        private static bool CheckCCNumber(long inputCCNumber)
        {

        }
    }
}
