namespace PatternSamples.AbstractFactory
{
    public interface ICar
    {
        string GetName();
    }
    
    public class Sedan : ICar
    {
        private readonly string _name;

        public Sedan(string name)
        {
            _name = name;
        }

        public string GetName() => _name;
    }

    public class Crossover : ICar
    {
        private readonly string _name;

        public Crossover(string name)
        {
            _name = name;
        }

        public string GetName() => _name;
    }
    
    //------------

    public interface ICarFactory
    {
        Sedan CreateSedan();
        Crossover CreateCrossover();
    }

    public class GoodCarFactory : ICarFactory
    {
        public Sedan CreateSedan()
        {
            return new Sedan("Good sedan");
        }

        public Crossover CreateCrossover()
        {
            return new Crossover("Good crossover");
        }
    }

    public class BadCarFactory : ICarFactory
    {
        public Sedan CreateSedan()
        {
            return new Sedan("Bad sedan");
        }

        public Crossover CreateCrossover()
        {
            return new Crossover("Bad crossover");
        }
    }
}