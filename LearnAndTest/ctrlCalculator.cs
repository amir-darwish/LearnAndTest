using System;
using System.Windows.Forms;

namespace LearnAndTest
{
    public partial class ctrlCalculator : UserControl
    {
        // Define an event to notify when the calculation is complete
        public event Action<double> OnCalculationComplete;

        // Method to raise the event
        protected virtual void RaiseCalculationComplete(double result)
        {
            Action<double> handler = OnCalculationComplete;
            if (handler != null)
            {
                handler(result);
            }
        }
        public ctrlCalculator()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbN1.Text, out double num1) && double.TryParse(tbN2.Text, out double num2))
            {
                double result = num1 + num2;
                lbResult.Text = result.ToString();

                // Raise the event to notify subscribers that the calculation is complete
                RaiseCalculationComplete(result);
            }
            else
            {
                MessageBox.Show("Please enter valid numbers.");
            }

        }
    }
}
