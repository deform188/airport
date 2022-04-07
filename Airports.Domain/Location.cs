using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Airports.Domain
{
    [DataContract]
    public class Location
    {
        [DataMember(Name = "lon")] public double Longitude { get; set; }
        [DataMember(Name = "lat")] public double Latitude { get; set; }
    }
}
