using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Chatbot
{
    public class TimerClass
    {
        private static System.Timers.Timer botTimer;

        /// <summary>
        /// methodd that sets the timer & then ends the timer 
        /// </summary>
        /// <param name="timer"></param>
        /// <returns></returns>
        public string SetTimer(int timer)
        {
            botTimer = new System.Timers.Timer(timer);
            int newtimer = timer * 1000;

            if (timer != 0) botTimer.Interval = newtimer;
            botTimer.Enabled = true;
            botTimer.Start();
            botTimer.Elapsed += async (sender, e) => await TimerEnded();

            botTimer.AutoReset = true;
            return timer.ToString();

        }
        private static Task TimerEnded()
        {
            botTimer.Stop();
            MessageBox.Show("Timer Ended");
            return Task.CompletedTask;
        }
    }
}
