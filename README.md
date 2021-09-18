# WeatherApp
Simple application to download weather data from server to local files and serve them via api

Im used a Hangfire NuGet for downloading / updating wather data from https://www.worldweatheronline.com/developer/

Data are storage in txt files and readed from them when request with city name is send

Get reqest have got construction: https://localhost:port/api/Weather?city=cityName

![image](https://user-images.githubusercontent.com/64928495/133869211-3ac5c6d4-ff9a-4028-adaf-2ac53bbc6fb8.png)
