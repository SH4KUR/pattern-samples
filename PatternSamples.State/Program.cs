using System;

namespace PatternSamples.State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("State: Traffic Light!\n");

            var trafficLight = new TrafficLight(new RedSignal());

            Console.WriteLine($": {trafficLight.LetCarGo()}");
            Console.WriteLine($": {trafficLight.LetCarGo()}");
            Console.WriteLine($": {trafficLight.LetCarGo()}");
            
            Console.Write("\nPress <ENTER>:");
            Console.ReadLine();
        }
    }
}
