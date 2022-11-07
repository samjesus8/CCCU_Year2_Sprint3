using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Chatbot.Music
{
    public partial class MusicPlayer : Form
    {
        public string Input { get; set; }

        public MusicPlayer()
        {
            InitializeComponent();
        }

        private async void playButton_Click(object sender, EventArgs e)
        {
            var client = new Client();
            string[] URL = Input.Split(" ");
            await client.GetVideoDetails(URL[1]);

            string NowPlaying = "Name - " + client.Title.ToString() + "\r\n" +
                                "Channel - " + client.ChannelName.ToString() + "\r\n" +
                                "Duration - " + client.Duration.ToString() + "\r\n";

            nowPlayingBox.Text = NowPlaying;
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {

        }

        private void stopButton_Click(object sender, EventArgs e)
        {

        }

        private void loopButton_Click(object sender, EventArgs e)
        {

        }
    }
}
