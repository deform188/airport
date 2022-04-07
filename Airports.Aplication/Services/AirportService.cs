using Airports.Aplication.AirportApi;
using Nest;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Airports.Aplication.Services
{
    public class AirportService : IAirportService
    {
        private readonly IAirportApiClient _airportApiClient;

        public AirportService(IAirportApiClient airportApiClient)
        {
            _airportApiClient = airportApiClient ?? throw new ArgumentNullException(nameof(airportApiClient));
        }

        public async Task<double> GetDistanceBetweenTwoPointAsync(string firstIATA, string secondIATA, CancellationToken cancellationToken)
        {
            var firstLocation = (await _airportApiClient.GetEntities<Domain.Airport>(firstIATA, cancellationToken))?.Location;
            var seconLocation = (await _airportApiClient.GetEntities<Domain.Airport>(secondIATA, cancellationToken))?.Location;

            double rlat1 = Math.PI * firstLocation.Latitude / 180;
            double rlat2 = Math.PI * seconLocation.Latitude / 180;
            double theta = firstLocation.Longitude - seconLocation.Longitude;
            double rtheta = Math.PI * theta / 180;
            double dist =
                Math.Sin(rlat1) * Math.Sin(rlat2) + Math.Cos(rlat1) *
                Math.Cos(rlat2) * Math.Cos(rtheta);
            dist = Math.Acos(dist);
            dist = dist * 180 / Math.PI;
            dist = dist * 60 * 1.1515;

            return Math.Round(dist, 2);
        }
    }
}
