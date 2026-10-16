using System;

namespace LearnAndTest.Events
{
    public class TemperatureChangedEventArgs : EventArgs
    {
        public double NewTemperature { get; }
        public double OldTemperature { get; }
        public double TemperatureDifference { get; }
        public TemperatureChangedEventArgs(double oldTemperature, double newTemperature)
        {
            OldTemperature = oldTemperature;
            NewTemperature = newTemperature;
            TemperatureDifference = newTemperature - oldTemperature;
        }
    }
}
