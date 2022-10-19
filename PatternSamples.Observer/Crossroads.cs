using System.Collections.Generic;

namespace PatternSamples.Observer
{
    public interface IObserver
    {
        void LookTrafficLight(ICrossroads crossroads);
    }
    
    public interface ICrossroads
    {
        void CarArrived(IObserver transport);
        void CarLeft(IObserver transport);
        void ChangeTrafficLightSignal();
        TrafficLightSignal GetTrafficLightSignal();
    }

    public enum TrafficLightSignal { Red, Green }

    public class Crossroads : ICrossroads
    {
        private readonly IList<IObserver> _transports = new List<IObserver>();
        
        public TrafficLightSignal Signal { get; set; }  = TrafficLightSignal.Red;

        public void CarArrived(IObserver transport)
        {
            _transports.Add(transport);
            transport.LookTrafficLight(this);
        }

        public void CarLeft(IObserver transport) => _transports.Remove(transport);

        public void ChangeTrafficLightSignal()
        {
            Signal = Signal == TrafficLightSignal.Green
                ? TrafficLightSignal.Red 
                : TrafficLightSignal.Green;
            
            foreach (var transport in _transports)
            {
                transport.LookTrafficLight(this);
            }
        }

        public TrafficLightSignal GetTrafficLightSignal() => Signal;
    }

    public class Transport : IObserver
    {
        public bool IsAllowed { get; set; }

        public void LookTrafficLight(ICrossroads crossroads)
        {
            IsAllowed = crossroads.GetTrafficLightSignal() == TrafficLightSignal.Green;
        }
    }
}