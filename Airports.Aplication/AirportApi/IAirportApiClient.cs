using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Airports.Aplication.AirportApi
{
    public interface IAirportApiClient
    {
        Task<T> GetEntities<T>(string contentType, CancellationToken cancellationToken);
    }
}
