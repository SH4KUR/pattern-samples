using System;

namespace PatternSamples.ChainOfResponsibility
{
    public interface IGossip
    {
        string Handle(string news);
        IGossip TellAnother(IGossip gossip);
    }

    public class GossipPerson : IGossip
    {
        private readonly string _name;
        private IGossip _nextGossip;

        public GossipPerson(string name)
        {
            _name = name;
        }

        public string Handle(string news)
        {
            var willGossip = new Random().Next(0, 5);
            news += $" + {_name}";

            if (willGossip > 3)
            {
                return $"{news}-stop!";
            }
            
            return _nextGossip != null 
                ? _nextGossip.Handle(news) 
                : news;
        }

        public IGossip TellAnother(IGossip gossip)
        {
            _nextGossip = gossip;
            return _nextGossip;
        }
    }
}