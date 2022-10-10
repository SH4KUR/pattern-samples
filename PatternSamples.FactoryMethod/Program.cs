using System;

namespace PatternSamples.FactoryMethod
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Factory Method: Poultry Farm!\n");

            var duckFarm = new DuckFarm();
            var cockFarm = new CockFarm();

            Console.WriteLine($"{nameof(duckFarm)}: {GetVoice(duckFarm)}");
            Console.WriteLine($"{nameof(cockFarm)}: {GetVoice(cockFarm)}");

            Console.Write("\nPress <ENTER>:");
            Console.ReadLine();
        }

        private static string GetVoice(PoultryFarm farm)
        {
            return farm.GenerateVoice();
        }
    }
}