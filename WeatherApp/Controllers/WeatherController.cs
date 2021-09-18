using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherApp.Domain;

namespace WeatherApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly IReadFileData _readFileData;

        public WeatherController(IReadFileData readFileData)
        {
            _readFileData = readFileData;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string city)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(city))
                {
                    return NotFound();
                }

                var data = await _readFileData.ReadDataFromFileAsync($"../Data/weatherData_{city}.txt");

                if (string.IsNullOrWhiteSpace(data))
                {
                    return NotFound();
                }

                return Ok(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }
    }
}
