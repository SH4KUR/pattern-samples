using System;
using System.Collections.Generic;
using System.Linq;

namespace PatternSamples.AbstractFactory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Abstract Factory: Car Factory!\n");

            var badCarFactory = new BadCarFactory();
            var goodCarFactory = new GoodCarFactory();

            var goodCars = GetCarList(goodCarFactory);
            var badCars = GetCarList(badCarFactory);

            Console.WriteLine($"Good : {string.Join(", ", goodCars.Select(c => c.GetName()))}");
            Console.WriteLine($"Bad  : {string.Join(", ", badCars.Select(c => c.GetName()))}");

            Console.Write("\nPress <ENTER>:");
            Console.ReadLine();
        }

        private static IEnumerable<ICar> GetCarList(ICarFactory carFactory)
        {
            return new ICar[]
            {
                carFactory.CreateSedan(),
                carFactory.CreateCrossover()
            };
        }
    }
}