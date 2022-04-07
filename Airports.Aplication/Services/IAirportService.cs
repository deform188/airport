using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Airports.Aplication.Services
{
    interface IAirportService
    {
        Task<double> GetDistanceBetweenTwoPointAsync(string firstIATA, string secondIATA, CancellationToken cancellationToken);
    }
}
