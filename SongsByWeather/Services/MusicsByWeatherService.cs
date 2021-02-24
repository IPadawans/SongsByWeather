using System;
using System.Threading.Tasks;
using SongsByWeather.Domain.Services;

namespace SongsByWeather.Services
{
    public class MusicsByWeatherService
    {
        private readonly IWeatherProviderService _weatherProviderService;
        private readonly IPlaylistProviderService _playlistProviderService;

        public MusicsByWeatherService(IWeatherProviderService weatherProviderService, IPlaylistProviderService playlistProviderService)
        {
            this._weatherProviderService = weatherProviderService;
            this._playlistProviderService = playlistProviderService;
        }

        public async Task<object> findPlaylistByWeatherInformingCity(String city)
        {
            double teste = await _weatherProviderService.getTemperatureInCelsiusByCity(city);

            return null;
        }

        public async Task<object> findplaylistByWeatherInformingLatitudeAndLongitude(int latitude, int longitude)
        {
            return null;
        }
    }
}
