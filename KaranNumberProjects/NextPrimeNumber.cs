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
            int currentPrimeNumber = 2;
            int currentPrimeValue = 2;
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
                            currentPrimeValue = ReturnNextPrimeNumber(currentPrimeValue);
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

        private static int ReturnNextPrimeNumber(int currentPrimeNumber)
        {
            bool isNumberPrime = false;
            int checkedNumber = currentPrimeNumber++;
            do
            {
                checkedNumber++;
                isNumberPrime = true;
                for (int i = checkedNumber - 1; i > 1; i--)
                {
                    Console.WriteLine("Checking {0} against {1}", checkedNumber, i);
                    if (checkedNumber % i == 0)
                    {
                        isNumberPrime = false;
                    }
                }
                
                
            }
            while (!isNumberPrime);

            Console.WriteLine("Prime number is {0}", currentPrimeNumber);
            return currentPrimeNumber;
        }
    }
}
