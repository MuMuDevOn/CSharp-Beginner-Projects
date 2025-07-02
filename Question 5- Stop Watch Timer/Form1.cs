using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_5__Stop_Watch_Timer
{
    public partial class StopWatch : Form
    {

        private DateTime startTime;
        public StopWatch()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
          //Set a value to start time
          startTime = DateTime.Now;

            //Start the time
            formtimer.Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            formtimer.Stop();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            formtimer.Stop();
            watchLabel.Text = "00.00.00";
        }

        private void formtimer_Tick(object sender, EventArgs e)
        {
            // Calculate how long it's been since start

            TimeSpan span = DateTime.Now - startTime;
            //dISPLAY THE TIME VALUE
            watchLabel.Text = span.ToString(@"mm\:ss\.ff");
        }
    }
}
