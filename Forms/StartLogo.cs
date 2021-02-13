using System;
using System.Windows.Forms;

namespace KeyboardTraining.Forms
{
    public partial class StartLogo : Form
    {
        public StartLogo()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
