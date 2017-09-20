using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaranNumberProjects
{
    class CollatzConjecture
    {
        public static void CheckCollatzConjecture()
        {
            bool correctInput = false;

            int inputNumber = 1;
            int numberOfSteps = 0;

            while (!correctInput)
            {
                Console.WriteLine("Enter an integer greater than 1");
                if (Int32.TryParse(Console.ReadLine(), out inputNumber))
                {
                    if (inputNumber > 0)
                    {
                        correctInput = true;
                        numberOfSteps = ReturnStepsCollatz(inputNumber);
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
            Console.WriteLine("It takes {0} steps for {1} to reach 1 by using the Collatz Conjecture", numberOfSteps, inputNumber);
            Console.ReadKey();
        }

        private static int ReturnStepsCollatz(int inputDigit)
        {
            int numberOfSteps = 0;
            while(inputDigit > 1)
            {
                numberOfSteps++;
                if (inputDigit % 2 == 0)
                {
                    inputDigit /= 2;
                }
                else
                {
                    inputDigit = inputDigit * 3 + 1;
                }
            }

            return numberOfSteps;
        }
    }
}
