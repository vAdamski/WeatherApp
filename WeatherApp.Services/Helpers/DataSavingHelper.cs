using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Domain;

namespace WeatherApp.Services
{
    public class DataSavingHelper : IDataSavingHelper
    {
        public string DownloadStringUrl(string address)
        {
            try
            {
                WebClient client = new WebClient();
                string reply = client.DownloadString(address);

                return reply;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool SaveWeatherDataToFile(string str, string cityName)
        {
            try
            {
                if (!String.IsNullOrEmpty(str))
                {
                    File.WriteAllText($"../weatherData_{cityName}.txt", str);
                    return true;
                }

                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
