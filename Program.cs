using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicles = new List<Vehicle>
            {
                new Zero { MainColor = "Midnight Blue" },
                new Zero { MainColor = "Black" },
                new Tesla { MainColor = "Burgundy" },
                new Cessna { MainColor = "White" },
                new Ram { MainColor = "Silver" }
            };

            foreach (var vehicle in vehicles)
            {
                vehicle.Drive();
                vehicle.Turn("right");
                vehicle.Stop();
                Console.WriteLine();
            }
        }
    }
}
