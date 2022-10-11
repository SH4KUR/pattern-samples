using System;

namespace PatternSamples.ChainOfResponsibility
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Chain of Responsibility: Gossip!\n");

            Console.WriteLine(ToGossip("Some cool!"));
            
            Console.Write("\nPress <ENTER>:");
            Console.ReadLine();
        }

        private static string ToGossip(string news)
        {
            var gossip1 = new GossipPerson("Nick");
            var gossip2 = new GossipPerson("Anna");
            var gossip3 = new GossipPerson("Dave");
            var gossip4 = new GossipPerson("Kate");
            var gossip5 = new GossipPerson("John");

            gossip1.TellAnother(gossip2)
                .TellAnother(gossip3)
                .TellAnother(gossip4)
                .TellAnother(gossip5);

            return $"Gossip: {gossip1.Handle(news)}";
        }
    }
}