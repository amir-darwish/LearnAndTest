using System;
using System.Windows.Forms;

namespace LearnAndTest
{
    public partial class ctrlCalculator : UserControl
    {
        // OLD CODE: Using a delegate for the event
        //// Define an event to notify when the calculation is complete
        //public event Action<double> OnCalculationComplete;

        //// Method to raise the event
        //protected virtual void RaiseCalculationComplete(double result)
        //{
        //    Action<double> handler = OnCalculationComplete;
        //    if (handler != null)
        //    {
        //        handler(result);
        //    }
        //}

        // NEW CODE: Using EventHandler<T> for the event
        public class CalculationEventArgs : EventArgs
        {
            public double Val1 { get; }
            public double Val2 { get; }

            public double Result { get; }
            public CalculationEventArgs(double val1, double val2, double result)
            {
                Val1 = val1;
                Val2 = val2;
                Result = result;
            }
        }
        public event EventHandler<CalculationEventArgs> OnCalculationComplete;

        public void RaiseCalculationComplete(double val1, double val2, double result)
        {
            RaiseCalculationComplete(new CalculationEventArgs(val1, val2, result));
        }

        protected void RaiseCalculationComplete(CalculationEventArgs e)
        {
            OnCalculationComplete?.Invoke(this, e);
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
                if (OnCalculationComplete != null)
                {
                    RaiseCalculationComplete(new CalculationEventArgs(num1, num2, result));
                }

            }
            else
            {
                MessageBox.Show("Please enter valid numbers.");
            }

        }
    }
}
