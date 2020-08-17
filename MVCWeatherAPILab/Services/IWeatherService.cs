using MVCWeatherAPILab.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVCWeatherAPILab.Services
{
    public interface IWeatherService
    {
        Task<Weather> GetAll();
    }
}
