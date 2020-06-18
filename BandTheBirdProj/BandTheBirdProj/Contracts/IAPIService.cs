using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BandTheBirdProj.Models;

namespace BandTheBirdProj.Contracts
{
    public interface IAPIService
    {
        Task<CurrentWeather> GetCurrentWeather(int zip);

        Task<GeoCode> GoogleGeocoding(string address);

        Task<List<Species>> GetSpecies();

    
    }
}
