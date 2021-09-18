using System.Threading.Tasks;

namespace WeatherApp.Domain
{
    public interface IReadFileData
    {
        Task<string> ReadDataFromFileAsync(string path);
    }
}