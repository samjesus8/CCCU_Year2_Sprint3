using MediaToolkit;
using MediaToolkit.Model;
using MediaToolkit.Options;
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
        public string Path { get; set; }

        public Client() 
        {
        }

        public async Task GetVideoDetails(string searchURL) 
        {
            //METHOD TO SEARCH FOR VIDEO DETAILS
            var youtubeClient = new YoutubeClient(); //Creating an Instance of the Youtube API

            if (searchURL == null || searchURL == "") 
            {
                Title = "";
                ChannelName = "";
                Duration = "";
                ReleaseDate = "";
            }
            else 
            {
                var videoSearch = await youtubeClient.Videos.GetAsync(searchURL); //Searching using URL

                Title = videoSearch.Title; //Setting each property in the class to its assosiated value
                ChannelName = videoSearch.Author.ChannelTitle;
                Duration = videoSearch.Duration.ToString();
                ReleaseDate = videoSearch.UploadDate.ToString();
            }
        }

        public async void DownloadAudio(string URL) 
        {
            //METHOD TO DOWNLOAD THE AUDIO OF YOUTUBE VIDEO
            var youtubeClient = new YoutubeClient();

            if (URL == null || URL == "") 
            {
                return;
            }
            else 
            {
                var streamManifest = await youtubeClient.Videos.Streams.GetManifestAsync(URL);
                var audioOnly = streamManifest.GetAudioStreams().TryGetWithHighestBitrate();

                await youtubeClient.Videos.Streams.DownloadAsync(audioOnly, @$"D:\UNI STUFF\Assignments\Year 2 Work\Software Development Project\Project Files\Sprint3\Chatbot\Music\Music Files\audio.{audioOnly.Container}");
            }
        }

        public void ConvertToWAV(string path) 
        {
            var inputPath = new MediaFile { Filename = @"D:\UNI STUFF\Assignments\Year 2 Work\Software Development Project\Project Files\Sprint3\Chatbot\Music\Music Files\audio.mp4" };
            var outputPath = new MediaFile { Filename = $@"D:\UNI STUFF\Assignments\Year 2 Work\Software Development Project\Project Files\Sprint3\Chatbot\Music\Music Files\{Title}.wav" };

            using (var engine = new Engine())
            {
                engine.Convert(inputPath, outputPath);
            }
            Path = outputPath.Filename;
        }
    }
}
