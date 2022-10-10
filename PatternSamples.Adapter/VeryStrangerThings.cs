namespace PatternSamples.Adapter
{
    public interface IStrangerThings
    {
        string GetStrange();
    }

    //------------
    
    public interface IVeryStrangerThings
    {
        string GetVeryStrange();
    }

    public class VeryStrangerThings : IVeryStrangerThings
    {
        public string GetVeryStrange()
        {
            return "VeryStrangerThings message";
        }
    }

    //------------
    
    public class Adapter : IStrangerThings
    {
        private IVeryStrangerThings _adaptee;

        public Adapter(IVeryStrangerThings adaptee)
        {
            _adaptee = adaptee;
        }

        public string GetStrange()
        {
            return _adaptee.GetVeryStrange();
        }
    }
}