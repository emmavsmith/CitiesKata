using System.Collections.Generic;

namespace CitiesKata.EF.Entities
{
    public class City
    {
        public City()
        {
            Attractions = new List<Attraction>();
        }

        public City(string name, long countryId, List<Attraction> attractions)
        {
            Name = name;
            CountryId = countryId;
            Attractions = attractions;
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long CountryId { get; set; }
        public bool Visited { get; set; }

        public virtual Country Country { get; set; }
        public virtual List<Attraction> Attractions { get; set; }
    }
}