using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BandTheBirdProj.Contracts;
using BandTheBirdProj.Models;
using Newtonsoft.Json;

namespace BandTheBirdProj.Services
{
    public class APICalls : IAPIService
    {

        public APICalls()
        {

        }

        public async Task<CurrentWeather> GetCurrentWeather(int zip)
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?zip=" + zip + ",us&appid=" + APIKey.WeatherAPI;

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                CurrentWeather weather = JsonConvert.DeserializeObject<CurrentWeather>(json);
                return weather;
            }
            return null;
        }

        public async Task<GeoCode> GoogleGeocoding(string address)
        {
            string url = "https://maps.googleapis.com/maps/api/geocode/json?address=" + address + "&key=" + APIKey.MapsAPI;

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<GeoCode>(json);

            }

            return null;

        }
    }
}
