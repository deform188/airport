using Airports.Aplication.AirportApi;
using Airports.Aplication.Services;
using Airports.Domain;
using Moq;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Airport.Tests
{
    public class AirportTest
    {
        [Fact]
        public async Task Test1Async()
        {
            IAirportApiClient AirportApiClientDependency = Mock.Of<IAirportApiClient>
            (ac => ac.GetEntities<Airports.Domain.Airport>("KVK", CancellationToken.None) == Task.FromResult(new Airports.Domain.Airport { Location = new Location { Latitude = 67.583333, Longitude = 33.583333 } })
            && ac.GetEntities<Airports.Domain.Airport>("ARH", CancellationToken.None) == Task.FromResult(new Airports.Domain.Airport { Location = new Location { Latitude = 64.597581, Longitude = 40.713989 } }));

            var airportService = new AirportService(AirportApiClientDependency);
            var distance = await airportService.GetDistanceBetweenTwoPointAsync("KVK", "ARH", CancellationToken.None);

            Assert.Equal(286.76, distance);
        }
    }
}
