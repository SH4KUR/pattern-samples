using System;

namespace PatternSamples.Composite
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Composite: Financial Pyramid!\n");

            var sub = new FinancialGroup();
            sub.Add(new Person(150));           // 450
            sub.Add(new Person(250));
            sub.Add(new Person(50));

            var main = new FinancialGroup();
            main.Add(new Person(100));          // 350
            main.Add(new Person(200));
            main.Add(new Person(50));
            main.Add(sub);

            Console.WriteLine($"Sum: {main.CountMoney()}");     // 800
            
            Console.Write("\nPress <ENTER>:");
            Console.ReadLine();
        }
    }
}