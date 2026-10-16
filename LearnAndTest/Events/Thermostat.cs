using System;

namespace LearnAndTest.Events
{
    public class Thermostat
    {
        public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;
        private double _currentTemperature;
        private double _oldTemperature;

        public void SetTemperature(double newTemperature)
        {
            _oldTemperature = _currentTemperature;
            _currentTemperature = newTemperature;
            // Raise the event when the temperature changes
            OnTemperatureChanged(new TemperatureChangedEventArgs(_oldTemperature, _currentTemperature));
        }

        public void OnTemperatureChanged(TemperatureChangedEventArgs e)
        {
            TemperatureChanged?.Invoke(this, e);
        }
    }
}
