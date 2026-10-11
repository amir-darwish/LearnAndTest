using System;
using System.Windows.Forms;

namespace LearnAndTest.Delegate
{
    public partial class Form2 : Form
    {
        public delegate void DataBackDelegate(object sender, string data);
        public event DataBackDelegate DataBackEvent;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dataToSend = textBox1.Text;
            DataBackEvent?.Invoke(this, dataToSend);
        }
    }
}
