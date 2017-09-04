using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaranNumberProjects
{
    class FibbonaciSequence
    {
        const double GoldenRatio = 1.61803398874989484820458683436;

        public static void NextFibonacci()
        {
            int digit = 0;
            bool correctInput = false;

            while (!correctInput)
            {
                Console.WriteLine("Find fibbonaci to the nth digit");
                if (Int32.TryParse(Console.ReadLine(), out digit))
                {
                    if (digit > 0)
                    {
                        correctInput = true;
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

            Console.WriteLine("Finding fibonacci to {0}th digit", digit);
            RtnFibonacci(digit);

            Console.ReadKey();
        }

        static void RtnFibonacci(int maxDigit)
        {
            int prevValue;
            Console.WriteLine(0);
            Console.WriteLine(1);
            if (maxDigit > 2)
            {
                for (int i = 2; i <= maxDigit; i++)
                {
                    Console.WriteLine(GoldenRatio ^ i - (1 - GoldenRatio) ^ i) / Math.Sqrt(5);

                }
            }
            else
            {

            }
            
        }
    }
}
