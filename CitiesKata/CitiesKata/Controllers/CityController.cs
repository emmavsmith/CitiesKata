using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using CitiesKata.EF.DbContext;
using CitiesKata.Models.Responses;

namespace CitiesKata.Controllers
{
    public class CityController : ApiController
    {
        // Todo: Dependency Injection
        private readonly CitiesKataContext _dbContext = new CitiesKataContext();

        // GET api/city
        public IHttpActionResult Get()
        {
            var response = new List<CityResponse>();
            var cities = _dbContext.Cities.ToList();

            foreach (var city in cities)
            {
                var attractions = new List<string>();
                foreach (var attraction in city.Attractions)
                {
                    attractions.Add(attraction.Name);
                }

                response.Add(new CityResponse(city.Name, city.Country.Name, attractions));
            }

            return this.Ok(response);
        }
    }
}
