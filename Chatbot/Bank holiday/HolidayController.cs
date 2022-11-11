using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;

namespace Chatbot
{
    public class HolidayController
    {
        /// <summary>
        /// Takes a Year input. Will then call a web requests from an api to get the public holidays using the inputted year and the set country Name.
        /// Will deseralize the result from the request and turn it into a list of Holiday details that include Name, Date, Local Name and Country.
        /// Will return this list of holidays.
        /// </summary>
        /// <param name="Year"></param>
        /// <returns></returns>
        public List<HolidayDetails> GetPublicHolidays(string Year)
        {
            string countryName = "GB";
            string year = Year;

            WebRequest request = WebRequest.Create("https://date.nager.at/api/v2/publicholidays/" + year + "/" + countryName);
            WebResponse response = request.GetResponse();
            Stream data = response.GetResponseStream();
            StreamReader reader = new StreamReader(data);
            string str = reader.ReadToEnd();
            dynamic json = JsonConvert.DeserializeObject(str);

            var results = new List<HolidayDetails>();
            foreach (var item in json)
            {
                results.Add(new HolidayDetails
                {
                    date = item.date,
                    country = item.country,
                    localName = item.localName,
                    name = item.name,
                });
            }
            return results;
        }

    }
}
