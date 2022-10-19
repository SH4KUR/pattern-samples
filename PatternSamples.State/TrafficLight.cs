using System;

namespace PatternSamples.State
{
    public class TrafficLight
    {
        private Signal _signal;

        public TrafficLight(Signal signal)
        {
            ChangeSignal(signal);
        }

        public void ChangeSignal(Signal signal)
        {
            _signal = signal;
            _signal.SetTrafficLight(this);
        }

        public bool LetCarGo()
        {
            return _signal.LetCarGo();
        }
    }

    public abstract class Signal
    {
        protected TrafficLight _trafficLight;
        
        public void SetTrafficLight(TrafficLight trafficLight)
        {
            _trafficLight = trafficLight;
        }

        public abstract bool LetCarGo();
    }

    public class RedSignal : Signal
    {
        public override bool LetCarGo()
        {
            Console.Write(nameof(RedSignal));
            
            _trafficLight.ChangeSignal(new YellowSignal());
            return false;
        }
    }

    public class YellowSignal : Signal
    {
        public override bool LetCarGo()
        {
            Console.Write(nameof(YellowSignal));
            
            _trafficLight.ChangeSignal(new GreenSignal());
            return false;
        }
    }

    public class GreenSignal : Signal
    {
        public override bool LetCarGo()
        {
            Console.Write(nameof(GreenSignal));
            
            _trafficLight.ChangeSignal(new RedSignal());
            return true;
        }
    }
}
