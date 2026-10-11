using System.Windows.Forms;

namespace LearnAndTest.Events
{
    public partial class frmSimpleEvent : Form
    {
        public frmSimpleEvent()
        {
            InitializeComponent();
        }

        private void ctrlCalculator1_OnCalculationComplete(double obj)
        {
            MessageBox.Show($"Calculation complete! Result: {obj}");
        }
    }
}
