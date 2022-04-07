using Airports.Aplication.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Airports.Aplication.Airport.Handlers
{
    internal class GetDistanceQueryHandler : IRequestHandler<GetDistanceQuery, double>
    {
        private readonly IAirportService _airportService;

        public GetDistanceQueryHandler(IAirportService airportService)
        {
            _airportService = airportService ?? throw new ArgumentNullException(nameof(airportService));
        }

        public async Task<double> Handle(GetDistanceQuery request, CancellationToken cancellationToken)
        {
            return await _airportService.GetDistanceBetweenTwoPointAsync(request.FirstIATA, request.SecondIATA, cancellationToken);
        }
    }
}
