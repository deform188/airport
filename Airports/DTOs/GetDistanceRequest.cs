using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Airports.DTOs
{
    public class GetDistanceRequest
    {
        [Required]
        [StringLength(3, ErrorMessage = "The IATA must have 3 characters.")]
        public string FirstIATA { get; set; }

        [Required]
        [StringLength(3, ErrorMessage = "The IATA must have 3 characters.")]
        public string SecondIATA { get; set; }
    }
}
