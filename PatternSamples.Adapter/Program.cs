using System;

namespace PatternSamples.Adapter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Adapter: Stranger Things!\n");

            var veryStrange = new VeryStrangerThings();
            var strangeAdapter = new Adapter(veryStrange);

            Console.WriteLine(strangeAdapter.GetStrange());
            
            Console.Write("\nPress <ENTER>:");
            Console.ReadLine();
        }
    }
}