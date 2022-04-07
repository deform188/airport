using Airports.Aplication.Airport;
using Airports.Aplication.CustomException;
using Airports.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Airports.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirportsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AirportsController(IMediator mediator) => _mediator = mediator;

        [HttpPost]
        public async Task<ActionResult> GetDistanceBetweenAirportsAsync([FromBody] GetDistanceRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var distance = await _mediator.Send(new GetDistanceQuery(request.FirstIATA, request.SecondIATA), cancellationToken);
                return Ok(distance);
            }
            catch (AirportNotFoundException ex)
            {
                return BadRequest(ex.Message);
            }     
        }
    }
}
