using System;

namespace PatternSamples.Proxy
{
    public interface IRoom
    {
        string Enter(Person person);
        string Exit(Person person);
    }

    public class Room : IRoom
    {
        public string Enter(Person person)
        {
            return $"{person.Name} enter room...";
        }

        public string Exit(Person person)
        {
            return $"{person.Name} exit room...";
        }
    }

    public class SupervisionProxy : IRoom
    {
        private readonly IRoom _room;

        public SupervisionProxy(IRoom room)
        {
            _room = room;
        }

        public string Enter(Person person)
        {
            return $"{DateTime.Now.ToLongTimeString()} : {_room.Enter(person)}";
        }

        public string Exit(Person person)
        {
            return $"{DateTime.Now.ToLongTimeString()} : {_room.Exit(person)}";
        }
    }

    public class Person
    {
        public Person(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}