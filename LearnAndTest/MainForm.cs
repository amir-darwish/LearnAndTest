using System;
using System.Windows.Forms;

namespace LearnAndTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deleagteForm form2 = new deleagteForm();
            form2.ShowDialog();
        }
    }
}
