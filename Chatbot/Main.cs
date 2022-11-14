using Chatbot.Music;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chatbot
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            keywordChecker KWC = new keywordChecker();

            KWC.WeatherInput(inputBox.Text, outputBox);

            //Example input
            if (inputBox.Text.ToLower().Contains("date")) 
            {
                string output = "The date today is " + DateTime.Now;
                outputBox.Text = output;
            }

            else if (inputBox.Text.ToLower().Contains("play")) 
            {
                outputBox.Text = "Opening Media Player...";

                var mediaPlayer = new MusicPlayer();
                mediaPlayer.Input = inputBox.Text.ToString(); //Get the URL from the user before loading the form
                mediaPlayer.Show();
            }
            
            KWC.WOTDInput(inputBox.Text, outputBox);

            KWC.BankHolidayInput(inputBox.Text, outputBox);

            KWC.TimerInput(inputBox.Text, outputBox);
        }
    }
}
