# WeatherApp
Simple application to download weather data from server to local files and serve them via api

Im used a Hangfire NuGet for downloading / updating wather data from https://www.worldweatheronline.com/developer/

Data are storage in txt files and readed from them when request with city name is send

Get reqest have construction: https://localhost:port/api/Weather?city=cityName
