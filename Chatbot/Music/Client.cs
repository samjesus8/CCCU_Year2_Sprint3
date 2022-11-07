using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace Chatbot.Music
{
    public class Client
    {
        public string SearchQuery { get; set; }

        public string Title { get; set; }
        public string ChannelName { get; set; }
        public string Duration { get; set; }

        public Client() 
        {
        }

        public async Task GetVideoDetails(string searchURL) 
        {
            var youtubeClient = new YoutubeClient();

            var videoSearch = await youtubeClient.Videos.GetAsync(searchURL);

            Title = videoSearch.Title;
            ChannelName = videoSearch.Author.ChannelTitle;
            Duration = videoSearch.Duration.ToString();
        }
    }
}
