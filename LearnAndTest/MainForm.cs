using LearnAndTest.Events;
using System;
using System.Windows.Forms;

namespace LearnAndTest
{
    public partial class MainForm : Form
    {
        private Thermostat _thermostat;
        public MainForm()
        {
            InitializeComponent();
            _thermostat = new Thermostat();
            _thermostat.TemperatureChanged += handlerTemperatureChanged; // Subscribe to the TemperatureChanged event
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deleagteForm form2 = new deleagteForm();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSimpleEvent form3 = new frmSimpleEvent();
            form3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmTemperatureChange frm = new frmTemperatureChange(_thermostat);
            frm.ShowDialog();
        }

        private void handlerTemperatureChanged(object sender, TemperatureChangedEventArgs e)
        {
            //MessageBox.Show($"Temperature changed from {e.OldTemperature:F2} °C to {e.NewTemperature:F2} °C");
            lblTemp.Text = e.NewTemperature.ToString("F2") + " °C";
        }
    }
}
