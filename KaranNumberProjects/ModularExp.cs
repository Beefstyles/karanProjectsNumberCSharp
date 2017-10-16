using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaranNumberProjects
{
    class ModularExp
    {
        public static void ModularExpImplementation()
        {
            int baseDigit = 0;
            int powerDigit = 0;
            bool correctInput = false;

            while (!correctInput)
            {
                Console.WriteLine("Enter base integer");
                if (Int32.TryParse(Console.ReadLine(), out baseDigit) && baseDigit > 0)
                {
                    Console.WriteLine("Enter power integer");
                    if(Int32.TryParse(Console.ReadLine(), out powerDigit) && powerDigit > 0)
                    {

                    }

                }
                else
                {
                    Console.WriteLine("Enter an integer");
                }

            }

            Console.WriteLine("Finding fibonacci to {0}th digit", baseDigit);
            FastExp(baseDigit, powerDigit);
            Console.ReadKey();
        }

        private static float FastExp(int baseDigit, int powerDigit)
        {
            if(powerDigit < 0)
            {
                return FastExp(1 / baseDigit, -powerDigit);
            }
            else if (powerDigit == 0)
            {
                return 1;
            }
            else if (powerDigit == 1)
            {
                return baseDigit;
            }

            else if (baseDigit % 2 == 0)
            {
                return FastExp(baseDigit * baseDigit, powerDigit / 2);
            }

            else if (baseDigit % 2 != 0)
            {
                return baseDigit * FastExp(baseDigit * baseDigit, (powerDigit - 1) / 2);
            }
        }
    }

}
