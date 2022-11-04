using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Chatbot
{
    /// <summary>
    /// Checks user input for keywords that then allows the bot to respond accordingly 
    /// 
    /// </summary>
    internal class keywordChecker
    {
        public DateTime convertDateTime(long sec) // Converts seconds to DateTime.
        {
            DateTime currentTime = DateTime.Now;
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(sec).ToLocalTime();

            return day;
        }
        public WeatherInfo.root GetWeather() // Gets the current weather using a url from an api.
        {

            WeatherInfo.root root;

            using (WebClient web = new())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?lat=51.2800275&lon=1.0802533&appid=7a024e9b075afd74e8bdac27fcbb6b70");
                var json = web.DownloadString(url);
                root = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
            }

            return root;
        }
        public void WeatherInput(string input, TextBox outputBox)
        {

            if (input.ToLower().Contains("weather")) // If the User mentions weather this shall be outputted
            {
                outputBox.Text = "Today in Canterbury The Forecast is - " + GetWeather().weather[0].main + "\r\nDescription: " + GetWeather().weather[0].description;
            }
            else if (input.ToLower().Contains("sunset")) // If the user mentions sunset this shall be outputted
            {
                outputBox.Text = "The Sunset in Canterbury Today is at - " + convertDateTime(GetWeather().sys.sunset).ToShortTimeString();
            }
            else if (input.ToLower().Contains("sunrise")) // If the user mentions sunrise this shall be outputted
            {
                outputBox.Text = "The Sunrise in Canterbury Today is at - " + convertDateTime(GetWeather().sys.sunrise).ToShortTimeString();
            }
            else if (input.ToLower().Contains("wind")) // if the user mentions wind this shall be outputted
            {
                outputBox.Text = "The Wind Speed in Canterbury is - " + GetWeather().wind.speed.ToString() + "Mph \r\nThe Wind Degrees is at - " + GetWeather().wind.deg.ToString() + "\r\nGusts of Upto - " + GetWeather().wind.gust.ToString() + "Mph";
            }
        }

        public WordOfDay.word GetWord() // gets the current word of the day using the API
        {
            WordOfDay.word word;

            word = new WordOfDay.word();

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://word-of-the-day2.p.rapidapi.com/word/today"),
            };
                     
            return word;

            ///<summary>
            /// below is the code from the APi website but I am unsure how to implement it. There's no tutorials really on how to code this that I can find. 
            /// above have based it on the code for the weather. 
            /// To do more research
            /// </summary>

            /*
             * var client = new HttpClient();
               var request = new HttpRequestMessage
            {
	               Method = HttpMethod.Get,
	               RequestUri = new Uri("https://word-of-the-day2.p.rapidapi.com/word/today"),
	              Headers =
	                {
		                { "X-RapidAPI-Key", "e849bcc6aemsh88ac2ae09d02290p196cf4jsn3f93c10f3361" },
		                { "X-RapidAPI-Host", "word-of-the-day2.p.rapidapi.com" },
	                },
            };
                using (var response = await client.SendAsync(request))
              {
	                  response.EnsureSuccessStatusCode();
	                   var body = await response.Content.ReadAsStringAsync();
	              Console.WriteLine(body);
                  }
            */
            
        }

        public void WOTDInput(string input, TextBox outputBox)
        {
            if (input.ToLower().Contains("word of the day")) // of user asks this this will be outputted
            {
                outputBox.Text = "The word of the day is: " + GetWord().wordText + "\r\nDefinition: " + GetWord().wordDefinition; 
            }
            else if (input.ToLower().Contains("wotd"))
            {
                outputBox.Text = "The word of the day is: " + GetWord().wordText + "\r\nDefinition: " + GetWord().wordDefinition;
            }
            else if (input.ToLower().Contains("Todays word"))
            {
                outputBox.Text = "The word of the day is: " + GetWord().wordText + "\r\nDefinition: " + GetWord().wordDefinition;
            }
        }
    }
}
