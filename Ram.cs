using System;

namespace Garage {
    public class Ram : Vehicle {
        public double FuelCapacity { get; set; }
        public void RefuelTank () { }
        //
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram drives past. Rrrrruuuummmmbbbllleee!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Ram carefully turns {direction}.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Ram gently rolls to a stop!");
        }
    }
}