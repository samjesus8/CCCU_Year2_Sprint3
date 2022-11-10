namespace Chatbot.Music
{
    public partial class MusicPlayer : Form
    {
        public string Input { get; set; }
        Client _client = new Client();

        public MusicPlayer()
        {
            InitializeComponent();
        }

        private async void playButton_Click(object sender, EventArgs e)
        {

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
            await _client.GetVideoDetails(URL[1]); //FOR NOW WHEN USING THIS MUSIC PLAYER PLEASE PUT "play VIDEOURL" AND HIT SEND
            _client.DownloadAudio(URL[1]);

            string NowPlaying = "Name - " + _client.Title.ToString() + "\r\n" +
                                "Channel - " + _client.ChannelName.ToString() + "\r\n" +
                                "Duration - " + _client.Duration.ToString() + "\r\n" +
                                "Release Date - " + _client.ReleaseDate.ToString();

            nowPlayingBox.Text = NowPlaying;
        }
    }
}
