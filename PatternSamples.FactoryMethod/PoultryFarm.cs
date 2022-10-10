namespace PatternSamples.FactoryMethod
{
    public interface IFowl
    {
        string Say();
    }

    public class Duck : IFowl
    {
        public string Say() => "Quack-quack!";
    }

    public class Cock : IFowl
    {
        public string Say() => "Cock-a-doodle-doo!";
    }

    //------------

    public abstract class PoultryFarm
    {
        public string GenerateVoice()
        {
            return GetFowl().Say();
        }
        
        public abstract IFowl GetFowl();
    }

    public class DuckFarm : PoultryFarm
    {
        public override IFowl GetFowl()
        {
            return new Duck();
        }
    }

    public class CockFarm : PoultryFarm
    {
        public override IFowl GetFowl()
        {
            return new Cock();
        }
    }
}