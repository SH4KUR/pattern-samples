using System;
using System.Threading;

namespace PatternSamples.Proxy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Proxy: Supervision!\n");

            var supervision = new SupervisionProxy(new Room());

            var person1 = new Person("Nick");
            var person2 = new Person("John");

            Console.WriteLine(supervision.Enter(person1));
            Thread.Sleep(1000);
            Console.WriteLine(supervision.Exit(person1));
            Thread.Sleep(1000);
            Console.WriteLine(supervision.Enter(person2));
            Thread.Sleep(1000);
            Console.WriteLine(supervision.Exit(person2));
            
            Console.Write("\nPress <ENTER>:");
            Console.ReadLine();
        }
    }
}