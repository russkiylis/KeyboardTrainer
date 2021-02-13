using System;
using System.Windows.Forms;

namespace KeyboardTraining
{
    public partial class GStatistics : Form
    {
        public GStatistics()
        {

            InitializeComponent();

            label2.Text = Properties.Settings.Default.TotalMissclicks.ToString();
            label6.Text = Properties.Settings.Default.AverageSpeed.ToString();
            label4.Text = Properties.Settings.Default.MaxSpeed.ToString();
            label8.Text = Properties.Settings.Default.AverageMissclicks.ToString();
            label10.Text = Properties.Settings.Default.TotalSessions.ToString();
            label12.Text = Properties.Settings.Default.CharsTyped.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
