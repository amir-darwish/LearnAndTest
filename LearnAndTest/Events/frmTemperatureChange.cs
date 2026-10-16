using System;
using System.Windows.Forms;

namespace LearnAndTest.Events
{

    public partial class frmTemperatureChange : Form
    {
        private Random random = new Random();
        private Thermostat thermostat;
        public frmTemperatureChange(Thermostat thermostat)
        {
            InitializeComponent();
            this.thermostat = thermostat;
            thermostat.TemperatureChanged += handlerTemperatureChanged; // Subscribe to the TemperatureChanged event


        }

        private void frmTemperature_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double newTemperature;

            newTemperature = random.NextDouble() * 100; // Generate a random temperature value
            thermostat.SetTemperature(newTemperature);
        }


        private void handlerTemperatureChanged(object sender, TemperatureChangedEventArgs e)
        {
            //MessageBox.Show($"Temperature changed from {e.OldTemperature:F2} °C to {e.NewTemperature:F2} °C");
            // Update the UI with the new temperature
            label1.Text = $"Old Temperature: {e.OldTemperature:F2} °C";
            label2.Text = $"New Temperature: {e.NewTemperature:F2} °C";
            label3.Text = $"Temperature Difference: {e.TemperatureDifference:F2} °C";
        }
    }
}
