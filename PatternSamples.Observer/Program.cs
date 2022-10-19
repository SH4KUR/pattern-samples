using System;

namespace PatternSamples.Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Observer: Crossroads!\n");

            var crossroads = new Crossroads();

            var car1 = new Transport();
            var car2 = new Transport();
            var truck = new Transport();
            
            crossroads.CarArrived(car1);
            crossroads.CarArrived(car2);
            crossroads.CarArrived(truck);

            Console.WriteLine($"Traffic Light: {crossroads.Signal}");
            Console.WriteLine($"{nameof(car1)}: {car1.IsAllowed}");
            Console.WriteLine($"{nameof(car2)}: {car2.IsAllowed}");
            Console.WriteLine($"{nameof(truck)}: {truck.IsAllowed}");

            crossroads.ChangeTrafficLightSignal();

            Console.WriteLine($"\nTraffic Light: {crossroads.Signal}");
            Console.WriteLine($"{nameof(car1)}: {car1.IsAllowed}");
            Console.WriteLine($"{nameof(car2)}: {car2.IsAllowed}");
            Console.WriteLine($"{nameof(truck)}: {truck.IsAllowed}");

            Console.Write("\nPress <ENTER>:");
            Console.ReadLine();
        }
    }
}
