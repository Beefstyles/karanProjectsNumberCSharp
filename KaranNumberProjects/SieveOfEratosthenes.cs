using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaranNumberProjects
{
    class SieveOfEratosthenes
    {
        public static void SieveInput()
        {
            bool correctInput = false;

            int inputNumber = 1;


            while (!correctInput)
            {
                Console.WriteLine("Enter an integer greater than 2 to generate primes up to and including that number");
                if (Int32.TryParse(Console.ReadLine(), out inputNumber))
                {
                    if (inputNumber > 0)
                    {
                        correctInput = true;
                        Sieve(inputNumber);
                    }
                    else
                    {
                        Console.WriteLine("Ensure input greater than zero");
                    }
                }
                else
                {
                    Console.WriteLine("Enter an integer");
                }
            }
            Console.ReadKey();
        }

        private static void Sieve(int maxNumber)
        {
            Dictionary<int, bool> sieveList = new Dictionary<int, bool>();

            for (int i = 2; i <= maxNumber; i++)
            {
                sieveList.Add(i, true);
            }

            int checkDigit = 2;
            for (int i = checkDigit; checkDigit* checkDigit <= maxNumber; i++)
                {
                    if (sieveList[i])
                    {
                        for (int j = checkDigit*2; j <= maxNumber; j+=checkDigit)
                        {
                            sieveList[j] = false;
                        }
                    }
                }
                checkDigit++;

            foreach (KeyValuePair<int,bool> entry in sieveList)
            {
                Console.WriteLine("{0}, {1}", entry.Key, entry.Value);
                if (entry.Value)
                {
                    Console.Write(entry.Key + " ");
                }
            }
        }
    }
}
