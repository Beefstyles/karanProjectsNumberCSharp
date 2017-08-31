using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaranNumberProjects
{
    class FibbonaciSequence
    {
   
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

            Console.WriteLine("Finding pi to {0}th digit", digit);
            RtnFibonacci(digit);

            Console.ReadKey();
        }

        static void RtnFibonacci(int maxDigit)
        {
            int previousValue = 0;
            for (int i = 0; i <= maxDigit; i+= previousValue)
            {
                Console.WriteLine(i);
                previousValue = i;
            }
        }
    }
}
