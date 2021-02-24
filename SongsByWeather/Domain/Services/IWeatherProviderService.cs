using System;
using System.Threading.Tasks;

namespace SongsByWeather.Domain.Services
{
    public interface IWeatherProviderService
    {
        Task<double> getTemperatureInCelsiusByCity(String city);
        Task<double> getTemperaturaInCelsiusByLatitudeAndLongitude(long latitude, long longitude);
    }
}
