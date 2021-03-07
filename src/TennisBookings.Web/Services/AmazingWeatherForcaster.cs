using System.Threading.Tasks;
using TennisBookings.Web.Domain;

namespace TennisBookings.Web.Services
{
    internal class AmazingWeatherForcaster : IWeatherForecaster
    {
        public Task<CurrentWeatherResult> GetCurrentWeatherAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}