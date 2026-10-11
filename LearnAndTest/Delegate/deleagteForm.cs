using System;
using System.Windows.Forms;
using LearnAndTest.Delegate;


namespace LearnAndTest
{
    public partial class deleagteForm : Form
    {

        public deleagteForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Delegate.Form2();
            form2.DataBackEvent += DataBackHandler;
            form2.ShowDialog();
        }

        private void DataBackHandler(object sender, string data)
        {
            textBox1.Text = data;
            if (data == "check")
            {
                MessageBox.Show("Received expected data from Form2.");
            }
        }
    }
}
