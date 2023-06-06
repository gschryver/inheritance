using System;

namespace Garage {
    public class Tesla : Vehicle {
        public double BatteryKWh { get; set; }
        public void ChargeBattery () { }
        //
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla drives past. MMmmmmmmmmm!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Tesla squeals around a {direction} turn.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla silently stops as if it never moved.");
        }
    }
}
