using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SongsByWeather.Services;
using SongsByWeather.Domain.Models;

namespace SongsByWeather.Controllers {
    [ApiController]
    [Route("/api/[controller]")]
    public class MusicsByWeatherController : ControllerBase {

        private readonly MusicsByWeatherService musicsByWeatherService;

        public MusicsByWeatherController(MusicsByWeatherService musicsByWeatherService)
        {
            this.musicsByWeatherService = musicsByWeatherService;
        }

        [HttpGet("get")]
        public async Task<IEnumerable<MusicInformation>> GetMusicsInformation(Nullable<int> latitude, Nullable<int> longitude, String cityName)
        {
            Task musics = (Task) await musicsByWeatherService.findPlaylistByWeatherInformingCity(cityName);
            return null;
        }
    }
}
