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

            if (viableNumber)
            {
                Console.WriteLine("Credit Card Number of {0} is a viable number", ccNumber);
            }
            else
            {
                Console.WriteLine("Credit Card Number of {0} is not a viable number", ccNumber);
            }
            Console.ReadKey();
        }

        private static bool CheckCCNumber(long inputCCNumber)
        {
            int sum = 0;
            string CCNumber = inputCCNumber.ToString();
            char[] CCNumberCharArr = CCNumber.ToCharArray();
            int numDigits = CCNumber.Length;
            int digit;
            int parityDigit = numDigits % 2;
            for (int i = 0; i < numDigits - 1; i++)
            {
                digit = CCNumberCharArr[i];
                if(i % 2 == parityDigit)
                {
                    digit *= 2;
                }
                if(digit > 9)
                {
                    digit -= 9;
                }
                sum += digit;
            }
            Console.WriteLine("Sum is {0}", sum);
            if(sum % 10 == 0)
            {
                Console.WriteLine("Sum mod 10 is {0}", sum % 10);
                return true;
            }
            else
            {
                Console.WriteLine("Sum mod 10 is {0}", sum % 10);
                return false;
            }
        }
    }
}
