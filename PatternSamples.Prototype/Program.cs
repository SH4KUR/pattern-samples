using System;

namespace PatternSamples.Prototype
{
    internal class Program
    {
        private const string Terminator20PartNo = "TRM 20 000";
        private const string Terminator40PartNo = "TRM 40 000";

        private static void Main(string[] args)
        {
            Console.WriteLine("Prototype: Terminator Clones!\n");

            var ter1 = new Terminator20000(Terminator20PartNo);
            ter1.RoundsCount = 20;
            
            var ter11 = (Terminator20000)ter1.Clone();

            var ter2 = new Terminator40000(Terminator40PartNo);
            ter2.LivesCount = 98;
            
            var ter22 = (Terminator40000)ter2.Clone();

            Console.WriteLine("\nTerminator 20 000:");
            Console.WriteLine(ter1.GetPartNo());
            Console.WriteLine(ter1.RoundsCount);
            Console.WriteLine(ter11.GetPartNo());
            Console.WriteLine(ter11.RoundsCount);

            Console.WriteLine("\nTerminator 40 000:");
            Console.WriteLine(ter2.GetPartNo());
            Console.WriteLine(ter2.LivesCount);
            Console.WriteLine(ter22.GetPartNo());
            Console.WriteLine(ter22.LivesCount);

            Console.Write("\nPress <ENTER>:");
            Console.ReadLine();
        }
    }
}