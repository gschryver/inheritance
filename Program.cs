using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args) 
        {
            Zero fxs = new Zero();
            Zero fxe = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Ram ram1500 = new Ram();

            fxs.MainColor = "Midnight Blue";
            fxe.MainColor = "Black";
            modelS.MainColor = "Burgundy";
            mx410.MainColor = "White";
            ram1500.MainColor = "Silver";

            fxs.Drive();
            fxs.Turn("right");
            fxs.Stop();
            Console.WriteLine();

            fxe.Drive();
            fxe.Turn("right");
            fxe.Stop();
            Console.WriteLine();

            modelS.Drive();
            modelS.Turn("right");
            modelS.Stop();
            Console.WriteLine();

            ram1500.Drive();
            ram1500.Turn("right");
            ram1500.Stop();
            Console.WriteLine();  

            mx410.Drive();
            mx410.Turn("right");
            mx410.Stop();
            Console.WriteLine();
      
        }
    }
}