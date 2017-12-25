using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaranNumberProjects
{
    class BinToFromDec
    {

        public static void BinToFromDecConverter()
        {
            int inputNumber = 0;
            string result = "";
            string choice;
            bool correctInput = false;
            bool correctNumberInput = false;
            bool decimalInput = false;

            while (!correctInput && !correctNumberInput)
            {
                while (!correctNumberInput)
                {
                    Console.WriteLine("Type d/D for decmial value to convert, b/B for binary");
                    choice = Console.ReadLine();
                    if(choice == "d" || choice == "D" || choice == "b" || choice == "B")
                    {
                        correctNumberInput = true;
                        if(choice == "d" || choice == "D")
                        {
                            decimalInput = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Only enter d/D or b/B");
                    }
                }

                if (decimalInput)
                {
                    Console.WriteLine("Enter decimal number");
                    if (Int32.TryParse(Console.ReadLine(), out inputNumber) && inputNumber > 0)
                    {
                        correctInput = true;
                        result = ReturnDecimalOrBinary(true, inputNumber);
                    }
                    else
                    {
                        Console.WriteLine("Enter an integer");
                    }
                }

                else
                {
                    Console.WriteLine("Enter binary number");
                    if (Int32.TryParse(Console.ReadLine(), out inputNumber) && inputNumber > 0)
                    {
                        correctInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Enter a binary number");
                        result = ReturnDecimalOrBinary(false, inputNumber);
                    }
                }
                

            }
            

            Console.WriteLine("Bnary version of dec number {0} is {1}", inputNumber, result);

            Console.ReadKey();
        }

        static string ReturnDecimalOrBinary (bool isDecimalInput, int number)
        {
            int toBase;
            if (isDecimalInput)
            {
                toBase = 2;
                string binaryResult = Convert.ToString(number, toBase);
                return binaryResult;
            }
            else
            {
                toBase = 10;
                string binaryResult = Convert.ToString(number, toBase);
                return binaryResult;
            }
        }
    }

}
