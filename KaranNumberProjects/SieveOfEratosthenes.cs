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
            //Create an array of bools indexed from 0 to maxNumber+1
            bool[] sieveArray = new bool[(maxNumber+1)];

            //Set all bools in sieveArray to true
            for (int i = 0; i < sieveArray.Length; i++)
            {
                sieveArray[i] = true;
            }

            //Start from smallest prime of 2
            for (int i = 2; i * i <= maxNumber; i++)
                {
                    //If sieveArray[i] is not changed by the following step, then it is prime (i.e. still true)
                    if (sieveArray[i])
                    {
                        //Update for all multiples of i
                        for (int j = i*2; j <= maxNumber; j+= i)
                        {
                            sieveArray[j] = false;
                        }
                    }
                }
            Console.WriteLine("Printing all primes up to and including {0}", maxNumber);
            for (int i = 2; i <= maxNumber; i++)
            {
                if (sieveArray[i])
                {
                    Console.Write(i + " ");
                }
            }
            
        }
    }
}
