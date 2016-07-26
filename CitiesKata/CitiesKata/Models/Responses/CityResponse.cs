using System.Collections.Generic;

namespace CitiesKata.Models.Responses
{
    public class CityResponse
    {
        public CityResponse(string name, string country, List<string> attractions)
        {
            Name = name;
            Country = country;
            Attractions = attractions;
        }

        public string Name { get; set; }
        public string Country { get; set; }
        public List<string> Attractions { get; set; }
    }
}