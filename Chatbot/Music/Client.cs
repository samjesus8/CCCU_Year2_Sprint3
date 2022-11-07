using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;

namespace Chatbot.Music
{
    public class Client
    {
        public string Title { get; set; }
        public string ChannelName { get; set; }
        public string Duration { get; set; }
        public string ReleaseDate { get; set; }

        public Client() 
        {
        }

        public async Task GetVideoDetails(string searchURL) 
        {
            //METHOD TO SEARCH FOR VIDEO DETAILS
            var youtubeClient = new YoutubeClient(); //Creating an Instance of the Youtube API

            var videoSearch = await youtubeClient.Videos.GetAsync(searchURL); //Searching using URL

            Title = videoSearch.Title; //Setting each property in the class to its assosiated value
            ChannelName = videoSearch.Author.ChannelTitle;
            Duration = videoSearch.Duration.ToString();
            ReleaseDate = videoSearch.UploadDate.ToString();
            
        }

        public async void DownloadAudio(string URL) 
        {
            //METHOD TO DOWNLOAD THE AUDIO OF YOUTUBE VIDEO
            var youtubeClient = new YoutubeClient();

            var streamManifest = await youtubeClient.Videos.Streams.GetManifestAsync(URL);
            var audioOnly = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();

            await youtubeClient.Videos.Streams.DownloadAsync(audioOnly, @$"D:\Visual Studio Projects\IMJS-Sprint-3\Chatbot\Music\Music Files\audio.{audioOnly.Container}");
        }
    }
}
