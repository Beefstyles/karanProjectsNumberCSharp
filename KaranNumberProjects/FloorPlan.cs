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
            decimal tileCost;
            decimal floorWidth;
            decimal floorLength;
            decimal floorTileCost;

            tileCost = ReturnTileCost();
            floorWidth = ReturnFloorWidth();
            floorLength = ReturnFloorLength();
            
            floorTileCost = ReturnTotalCostOfTile(tileCost, floorWidth, floorLength);
            Console.WriteLine("At a tile cost of ${0} per square metre it would cost ${1} to tile a floor area of {2} m2", tileCost, floorTileCost, (floorWidth * floorLength));
            Console.ReadKey();
        }

        private static decimal ReturnTotalCostOfTile(decimal costOfTilePerSquareMetre, decimal floorWidth, decimal floorLength)
        {
            return (floorWidth * floorLength) * costOfTilePerSquareMetre;
        }

        private static decimal ReturnTileCost()
        {
            decimal tileCost = 0;
            bool correctTileCostInput = false;
            while (!correctTileCostInput)
            {
                Console.WriteLine("Enter tile cost in dollars per square metre");
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
            return tileCost;
        }

        private static decimal ReturnFloorWidth()
        {
            bool correctFloorWidthInput = false;
            decimal floorWidth = 0;
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
            return floorWidth;
        }

        private static decimal ReturnFloorLength()
        {
            bool correctFloorLengthInput = false;
            decimal floorLength = 0;
            while (!correctFloorLengthInput)
            {
                Console.WriteLine("Enter floor length in metres");
                if (Decimal.TryParse(Console.ReadLine(), out floorLength))
                {
                    if (floorLength > 0)
                    {
                        correctFloorLengthInput = true;
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
            return floorLength;
        }
    }
}

