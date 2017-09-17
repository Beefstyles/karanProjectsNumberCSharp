using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaranNumberProjects
{
    class FloorPlan
    {
        public static void CalculateFloorPlan()
        {
            bool correctTileCostInput = false;
            bool correctFloorWidthInput = false;
            bool correctFloorLengthInput = false;
            decimal tileCost;
            decimal floorWidth;
            decimal floorLength;

            while (!correctTileCostInput)
            {
                Console.WriteLine("Enter tile cost per square metre");
                if (Decimal.TryParse(Console.ReadLine(), out tileCost))
                {
                    if (tileCost > 0)
                    {
                        correctTileCostInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Ensure input greater than zero");
                    }
                }
                else
                {
                    Console.WriteLine("Enter a decimal");
                }
            }

            while (!correctFloorWidthInput)
            {
                Console.WriteLine("Enter floor width in metres");
                if (Decimal.TryParse(Console.ReadLine(), out floorWidth))
                {
                    if (floorWidth > 0)
                    {
                        correctFloorWidthInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Ensure input greater than zero");
                    }
                }
                else
                {
                    Console.WriteLine("Enter a decimal");
                }
            }
        }
}
