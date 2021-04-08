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
    public partial class Form1 : Form
    {
        public System.Timers.Timer mijnTimer;
        public int interval;
        public Form1()
        {
            InitializeComponent();
            lblTitel.Text = "StandSitDesk V0.1";
            WaitforTimerAsync();
        }
        public static async Task WaitforTimerAsync()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("wacht seconden:  10");
                Task.Delay(10 * 1000).Wait();
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Iets om op te clikken tijdens Await task");
        }
        private void btnResetTimer_Click(object sender, EventArgs e)
        {
            // code om timer op 0 of whatever te zetten.
            Console.WriteLine("Timer is geReset!");
        }
    }
}
