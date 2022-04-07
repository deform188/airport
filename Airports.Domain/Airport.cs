using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Airports.Domain
{
    [DataContract]
    public class Airport
    {
        [DataMember(Name = "country")] public string Country { get; protected set; }
        [DataMember(Name = "city_iata")] public string CityIata { get; protected set; }
        [DataMember(Name = "iata")] public string Iata { get; protected set; }
        [DataMember(Name = "city")] public string City { get; protected set; }
        [DataMember(Name = "timezone_region_name")] public string TimezoneRegionName { get; protected set; }
        [DataMember(Name = "country_iata")] public string CountryIata { get; protected set; }
        [DataMember(Name = "rating")] public int Rating { get; protected set; }
        [DataMember(Name = "name")] public string Name { get; protected set; }
        [DataMember(Name = "location")] public Location Location { get; set; }
        [DataMember(Name = "type")] public string Type { get; protected set; }
        [DataMember(Name = "hubs")] public int Hubs { get; protected set; }
    }
}
