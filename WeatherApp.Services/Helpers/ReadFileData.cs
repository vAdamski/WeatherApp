using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Domain;

namespace WeatherApp.Services
{
    public class ReadFileData : IReadFileData
    {
        public async Task<string> ReadDataFromFileAsync(string path)
        {
            try
            {
                if (!File.Exists(path))
                {
                    return null;
                }

                var data = await File.ReadAllTextAsync(path);

                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }
    }
}
