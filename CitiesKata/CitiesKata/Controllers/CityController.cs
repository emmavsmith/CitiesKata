using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using CitiesKata.EF.DbContext;

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
                response.Add(new CityResponse(city.Name));
            }

            return this.Ok(response);
        }
    }

    public class CityResponse
    {
        public CityResponse(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
