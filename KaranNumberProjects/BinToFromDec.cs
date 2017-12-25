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
            string resultBin = "";
            string resultDec = "";
            string choice;
            bool correctInput = false;
            bool correctNumberInput = false;
            bool decimalInput = false;

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

                while (!correctInput)
                {
                    if (decimalInput)
                    {
                        Console.WriteLine("Enter decimal number");
                        if (Int32.TryParse(Console.ReadLine(), out inputNumber) && inputNumber > 0)
                        {
                            correctInput = true;
                            resultBin = ReturnDecimalOrBinary(true, inputNumber);
                            Console.WriteLine("Binary version of decimal number {0} is {1}", inputNumber, resultBin);
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
                            Console.WriteLine(inputNumber);
                            resultDec = ReturnDecimalOrBinary(false, inputNumber);
                            Console.WriteLine("Decimal version of binary number {0} is {1}", inputNumber, resultDec);
                        }
                        else
                        {
                            Console.WriteLine("Enter a binary number");
                        }
                    }
            }
            Console.ReadKey();
        }

        static string ReturnDecimalOrBinary (bool isDecimalInput, int number)
        {
            int toBase;
            int fromBase;
            if (isDecimalInput)
            {
                toBase = 2;
                string decimalResult = Convert.ToString(number, toBase);
                return decimalResult;
            }
            else
            {
                try
                {
                    fromBase = 2;
                    long bin = Convert.ToInt64(number.ToString(), fromBase);
                    string binaryResult = ((int)bin).ToString();
                    return binaryResult;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("You didn't enter a correct binary code. Only 1 or 0 allowed.");
                    return "Error";
                }
                
            }
        }
    }

}
