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
            int primeNumberPos = 1;
            int currentPrimeValue = 1;
            string input;
            while (!exitLoop)
            {
                while (!correctInput)
                {
                    Console.WriteLine("Enter Y to find the next prime number, N to exit");
                    input = Console.ReadLine();
                    if (input == "y" || input == "Y" || input == "N" || input == "n")
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
            int checkedNumber = currentPrimeNumber;
            do
            {
                checkedNumber++;
                isNumberPrime = true;
                for (int i = checkedNumber - 1; i > 1; i--)
                {
                    // if checked number is divisible by a value then not prime
                    if (checkedNumber % i == 0)
                    {
                        isNumberPrime = false;
                    }
                }
                
            }
            while (!isNumberPrime);

            Console.WriteLine("Prime number is {0}", checkedNumber);
            return checkedNumber;
        }
    }
}
