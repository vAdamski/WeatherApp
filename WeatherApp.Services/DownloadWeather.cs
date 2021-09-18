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
    public class DownloadWeather : IDownloadWeather
    {
        public List<string> Cities { get; set; }
        private readonly IDataSavingHelper _savingHelper;


        public DownloadWeather(IDataSavingHelper savingHelper)
        {
            Cities = new List<string>() { "Lodz", "Warsaw", "Poznan", "Wroclaw" };
            _savingHelper = savingHelper;
        }

        public bool DownloadWeatherData()
        {
            try
            {
                foreach (var city in Cities)
                {
                    var str = _savingHelper.DownloadStringUrl($"http://api.worldweatheronline.com/premium/v1/weather.ashx?key=25b7a9217684471ea6a113336211509&q={city}&format=json&num_of_days=1");
                    if (string.IsNullOrEmpty(str))
                    {
                        continue;
                    }

                    var result = _savingHelper.SaveWeatherDataToFile(str, city);
                    if (!result)
                    {
                        Console.WriteLine($"Saving data for {city} failed!");
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }
    }
}
