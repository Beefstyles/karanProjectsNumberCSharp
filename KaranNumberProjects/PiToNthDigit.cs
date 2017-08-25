using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaranNumberProjects
{
    class PiToNthDigit
    {
        int count = 0;
        public void CalculatePiToNthDigit()
        {
            int digit = 0;
            bool correctInput = false;
            double piCalculated;
            

            while (!correctInput)
            {
                Console.WriteLine("Find pi to the nth digit");
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

            Console.WriteLine(piReturn(digit));
            Console.ReadKey();
        }

        double piReturn(int digit)
        {
            return 1 + digit / (2.0 * digit + 1) * piReturn(digit + 1);
        }
    }
}
