namespace PatternSamples.Prototype
{
    public interface IRobot
    {
        string GetPartNo();
        IRobot Clone();
    }

    public abstract class Terminator : IRobot
    {
        protected readonly string PartNo;

        protected Terminator(string partNo)
        {
            PartNo = partNo;
        }
        
        public string GetPartNo() => PartNo;
        public abstract IRobot Clone();
    }

    public class Terminator20000 : Terminator
    {
        public Terminator20000(string partNo) : base(partNo)
        {
        }

        public int RoundsCount { get; set; } = 50;

        public string RideBike() => "Leaving on a Bike...";
        public string ShotFromShotgun() => "Shotgun Shot!";

        public override IRobot Clone()
        {
            return new Terminator20000(PartNo)
            {
                RoundsCount = RoundsCount
            };
        }
    }

    public class Terminator40000 : Terminator
    {
        public Terminator40000(string partNo) : base(partNo)
        {
        }

        public int LivesCount { get; set; } = 100;
        
        public string Recover() => "Recovering...";
        public string RocketLauncherShot() => "Rocket Launcher Shot!!!";

        public override IRobot Clone()
        {
            return new Terminator40000(PartNo)
            {
                LivesCount = LivesCount
            };
        }
    }
}