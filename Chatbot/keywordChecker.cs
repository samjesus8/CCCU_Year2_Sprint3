using AngleSharp.Html.Dom;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Chatbot
{
    /// <summary>
    /// Checks user input for keywords that then allows the bot to respond accordingly 
    /// 
    /// </summary>
    internal class keywordChecker
    {
        private WebClient client;

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

        /// <summary>
        /// Methods that retruns a word of the day using the API
        /// </summary>
        /// <returns></returns>
        public string GetWord() 
        {
            string word; 
            WebClient client;

            client = new WebClient();
            word = client.DownloadString("https://random-word-api.herokuapp.com/word");

            return word; 
            
        }

        public void WOTDInput(string input, TextBox outputBox)
        {
            if (input.ToLower().Contains("word of the day")) // if user asks this this will be outputted
            {
                outputBox.Text = "The word of the day is: " + GetWord();
            }
            else if (input.ToLower().Contains("wotd"))
            {
                outputBox.Text = "The word of the day is: " + GetWord();
            }
            else if (input.ToLower().Contains("Todays word"))
            {
                outputBox.Text = "The word of the day is: " + GetWord();
            }
         
        }
        /// <summary>
        /// Method that will return the Bank holidays for a certain year.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="outputBox"></param>
        public void BankHolidayInput(string input, TextBox outputBox)
        {
            HolidayController HC = new HolidayController();

            if (input.ToLower().Contains("bank holidays") && input.ToLower().Contains("next year")) // Will return the bank holidays for the next year not the current year
            {
                string output = "";

                foreach (HolidayDetails HD in HC.GetPublicHolidays((DateTime.Now.Year + 1).ToString())) // Loop to add all holidays to an output string.
                {
                    output = output + "Date - " + HD.date.ToString("dd/MM/yyyy") + " | Name - " + HD.name + " \r\n";
                }

                outputBox.Text = output;
            }
            else if (input.ToLower().Contains("bank holiday")) // Will return all the bank holidays for the current year..
            {
                string output = "";

                foreach (HolidayDetails HD in HC.GetPublicHolidays(DateTime.Now.Year.ToString()))
                {
                    output = output + "Date - " + HD.date.ToString("dd/MM/yyyy") + " | Name - " + HD.name + "\r\n";
                }

                outputBox.Text = output;
            }
            else if (input.ToLower().Contains("bank holidays"))
            {
                string output = "";

                foreach (HolidayDetails HD in HC.GetPublicHolidays(DateTime.Now.Year.ToString()))
                {
                    output = output + "Date - " + HD.date.ToString("dd/MM/yyyy") + " | Name - " + HD.name + " \r\n";
                }

                outputBox.Text = output;
            }
        }

        
       /// <summary>
       /// Method that sets a timer
       /// </summary>
       /// <param name="input"></param>
       /// <param name="outputBox"></param>

        public void TimerInput(string input, TextBox outputBox)
            
        {
            TimerClass timer1 = new TimerClass(); //creates timer object

            int timer;
            string t  = new string (input.Where(char.IsDigit).ToArray()); // checks if input has a digit 
            bool containsInt = int.TryParse(t, out timer); // outputs the digit as the timer
                       

            if (input.ToLower().Contains("set timer"))
            {
                outputBox.Text = "Timer set for: " + timer1.SetTimer(timer);
            }
        }
        
    }
}
