using System;
using System.Net.Http;
using System.Threading.Tasks;
using SongsByWeather.Domain.Services;
namespace SongsByWeather.Services
{
    public class OpenWeatherMapsWeatherProviderService : IWeatherProviderService
    {
        static HttpClient client = new HttpClient();
        static readonly String baseURL = "https://api.openweathermap.org/data/2.5/weather";

        public OpenWeatherMapsWeatherProviderService()
        {
        }

        public async Task<double> getTemperaturaInCelsiusByLatitudeAndLongitude(long latitude, long longitude)
        {
            throw new NotImplementedException();
        }

        public async Task<double> getTemperatureInCelsiusByCity(string city)
        {
            //HttpResponseMessage response = await client.GetAsync(baseURL);

            return 31.0;
        }
    }
}
