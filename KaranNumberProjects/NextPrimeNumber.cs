using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaranNumberProjects
{
    class NextPrimeNumber
    {
        public static void FindNextPrimeNumber()
        {
            bool exitLoop = false;
            bool correctInput = false;
            int primeNumberPos = 0;
            string input;
            while (!exitLoop)
            {
                Console.WriteLine("Enter Y to find the next prime number, N to exit");
                while (!correctInput)
                {
                    input = Console.ReadLine();
                    if (input == "y" || input == "Y" || input == "N" || input == "Y")
                    {
                        correctInput = true;
                        if (input == "y" || input == "Y")
                        {
                            Console.WriteLine("Returning the {0}th prime", primeNumberPos);
                            ReturnNextPrimeNumber(primeNumberPos);
                            primeNumberPos++;
                            correctInput = false;
                        }
                        else
                        {
                            exitLoop = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter Y or N");
                    }
                }
                
            }
            Console.WriteLine("Exiting Program");
            Console.ReadKey();
        }

        private static void ReturnNextPrimeNumber(int currentPrimeNumber)
        {
            bool isNumberPrime;
            for (int i = currentPrimeNumber - 1; i > 0; i--)
            {

            }
        }
    }
}
