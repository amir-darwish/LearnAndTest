using System.Windows.Forms;

namespace LearnAndTest.Events
{
    public partial class frmSimpleEvent : Form
    {
        public frmSimpleEvent()
        {
            InitializeComponent();
        }

        private void ctrlCalculator1_OnCalculationComplete(object sender, ctrlCalculator.CalculationEventArgs e)
        {

        }

        private void ctrlCalculator1_OnCalculationComplete_1(object sender, ctrlCalculator.CalculationEventArgs e)
        {
            MessageBox.Show($"Calculation complete! Result: {e.Result} and values: val1: {e.Val1}, val2: {e.Val2}");
        }

        //private void ctrlCalculator1_OnCalculationComplete(double obj)
        //{
        //    MessageBox.Show($"Calculation complete! Result: {obj}");
        //}
    }
}
