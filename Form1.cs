using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace StandSitDesk
{
    public partial class lblForm1 : Form
    {
        public System.Timers.Timer mijnTimer;
        public int interval;
        public lblForm1()
        {
            InitializeComponent();
            lblTimer.Text = "Wanneer is het weer eens tijd om je zit/sta bureau in hoogte te wisselen?";
            numericUpDown1.Minimum = 15;
            numericUpDown1.Value = 45;
            numericUpDown1.Maximum = 120;
            
        }
        public static async Task WaitforTimerAsync(int lokaalGetal)
        {
            await Task.Delay(lokaalGetal * 60 * 1000); 
            MessageBox.Show(DateTime.Now.ToString("HH:mm") + " Tijd om je bureau in hoogte te wisselen!");
        }
        private void btnResetTimer_Click(object sender, EventArgs e)
        {
            interval = Convert.ToInt32(numericUpDown1.Value);
            DateTime newTime = DateTime.Now.AddMinutes(interval);
            lblSwitch.Text = "Timer is geStart met interval van: " + interval + " minuten";
            lblInterval.Text = "Dus hoogte verstellen om: " + newTime.ToString("HH:mm") + " uur";
            WaitforTimerAsync(interval);
        }

        private void lblSwitch_Click(object sender, EventArgs e)
        {

        }

        private void lblInterval_Click(object sender, EventArgs e)
        {

        }
    }
}
