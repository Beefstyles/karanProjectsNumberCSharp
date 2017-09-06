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
                        if(digit <= 90)
                        {
                            correctInput = true;
                        }
                        else
                        {
                            Console.WriteLine("Ensure input is less than 90 due to limitation of long");
                        }
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
            long prevValue = 1;
            long prevValueMinus = 0;
            long currentValue = 1;
            Console.WriteLine(prevValueMinus);
            Console.WriteLine(prevValue);
            if (maxDigit > 2)
            {
                for (int i = 1; i <= maxDigit; i++)
                {
                    currentValue = prevValueMinus + prevValue;
                    prevValueMinus = prevValue;
                    prevValue = currentValue;
                    Console.WriteLine(currentValue);
                }
            }            
        }
    }
}
