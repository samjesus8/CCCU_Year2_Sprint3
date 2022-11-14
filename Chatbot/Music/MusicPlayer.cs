using System;
using System.Media;
using System.Threading;

namespace Chatbot.Music
{
    public partial class MusicPlayer : Form
    {
        private Thread _thread;
        public string Input { get; set; }
        Client _client = new Client();
        SoundPlayer player;

        public MusicPlayer()
        {
            InitializeComponent();
        }

        private async void playButton_Click(object sender, EventArgs e)
        {
            _thread = new Thread(new ThreadStart(PlayMusic));
            _thread.IsBackground = true;
            _thread.Start();
        }

        private async void pauseButton_Click(object sender, EventArgs e)
        {

        }

        private async void stopButton_Click(object sender, EventArgs e)
        {

        }

        private async void loopButton_Click(object sender, EventArgs e)
        {

        }

        private async void MusicPlayer_Load(object sender, EventArgs e)
        {
            string[] URL = Input.Split(" ");

            if (URL[1] == null || URL[1] == "") 
            {
                MessageBox.Show("No URL/Search term provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            await _client.GetVideoDetails(URL[1]); //FOR NOW WHEN USING THIS MUSIC PLAYER PLEASE PUT "play VIDEOURL" AND HIT SEND
            _client.DownloadAudio(URL[1]);
            _client.ConvertToWAV(URL[1]);

            string NowPlaying = "Name - " + _client.Title.ToString() + "\r\n" +
                                "Channel - " + _client.ChannelName.ToString() + "\r\n" +
                                "Duration - " + _client.Duration.ToString() + "\r\n" +
                                "Release Date - " + _client.ReleaseDate.ToString();

            nowPlayingBox.Text = NowPlaying;
        }

        public void PlayMusic() 
        {
            player = new SoundPlayer($@"D:\UNI STUFF\Assignments\Year 2 Work\Software Development Project\Project Files\Sprint3\Chatbot\Music\Music Files\{_client.Title}.wav");
            player.PlaySync();
        }
    }
}
