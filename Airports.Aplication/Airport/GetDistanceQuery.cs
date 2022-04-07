using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airports.Aplication.Airport
{
    public class GetDistanceQuery : IRequest<double>
    {
        public string FirstIATA { get; }

        public string SecondIATA { get; }

        public GetDistanceQuery(string firstIATA, string secondIATA)
        {
            FirstIATA = firstIATA ?? throw new ArgumentNullException(nameof(firstIATA));
            SecondIATA = secondIATA ?? throw new ArgumentNullException(nameof(secondIATA));
        }
    }
}
