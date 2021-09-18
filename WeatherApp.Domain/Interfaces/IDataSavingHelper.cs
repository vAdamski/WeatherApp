namespace WeatherApp.Domain
{
    public interface IDataSavingHelper
    {
        string DownloadStringUrl(string address);
        bool SaveWeatherDataToFile(string str, string cityName);
    }
}