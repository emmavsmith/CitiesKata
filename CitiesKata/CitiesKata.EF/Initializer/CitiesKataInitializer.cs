using System.Collections.Generic;
using System.Linq;
using CitiesKata.EF.DbContext;
using CitiesKata.EF.Entities;

namespace CitiesKata.EF.Initializer
{
    public class CitiesKataInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CitiesKataContext>
    {
        protected override void Seed(CitiesKataContext context)
        {
            CreateAttractions(context);
            CreateCountries(context);
            CreateCities(context);
        }

        private static void CreateCities(CitiesKataContext context)
        {
            var attractionsManc = new List<Attraction>()
            {
                context.Attractions.Single(x => x.Name == "Football"),
                context.Attractions.Single(x => x.Name == "Bars")
            };

            var attractionsLiv = new List<Attraction>()
            {
                context.Attractions.Single(x => x.Name == "Football"),
                context.Attractions.Single(x => x.Name == "Bars"),
                context.Attractions.Single(x => x.Name == "Music")
            };

            var attractionsYork = new List<Attraction>()
            {
                context.Attractions.Single(x => x.Name == "City Walls"),
                context.Attractions.Single(x => x.Name == "Cathedral")
            };

            var attractionsLasVegas = new List<Attraction>()
            {
                context.Attractions.Single(x => x.Name == "Casinos"),
                context.Attractions.Single(x => x.Name == "Grand Canyon"),
                context.Attractions.Single(x => x.Name == "Shows")
            };

            var attractionsBejing = new List<Attraction>()
            {
                context.Attractions.Single(x => x.Name == "Forbidden City"),
                context.Attractions.Single(x => x.Name == "Great Wall of China")
            };

            var cities = new List<City>()
            {
                new City("Manchester", context.Countries.Single(x => x.Name == "UK").Id, attractionsManc),
                new City("Liverpool", context.Countries.Single(x => x.Name == "UK").Id, attractionsLiv),
                new City("York", context.Countries.Single(x => x.Name == "UK").Id, attractionsYork),
                new City("Las Vegas", context.Countries.Single(x => x.Name == "USA").Id, attractionsLasVegas),
                new City("Bejing", context.Countries.Single(x => x.Name == "China").Id, attractionsBejing)
            };

            cities.ForEach(city => context.Cities.Add(city));
            context.SaveChanges();
        }

        private static void CreateCountries(CitiesKataContext context)
        {
            var countries = new List<Country>()
            {
                new Country("UK"),
                new Country("USA"),
                new Country("China")
            };

            countries.ForEach(country => context.Countries.Add(country));
            context.SaveChanges();
        }

        private static void CreateAttractions(CitiesKataContext context)
        {
            var attractions = new List<Attraction>()
            {
                new Attraction("Football"),
                new Attraction("Bars"),
                new Attraction("Music"),
                new Attraction("City Walls"),
                new Attraction("Cathedral"),
                new Attraction("Casinos"),
                new Attraction("Grand Canyon"),
                new Attraction("Shows"),
                new Attraction("Forbidden City"),
                new Attraction("Great Wall of China")
            };

            attractions.ForEach(attraction => context.Attractions.Add(attraction));
            context.SaveChanges();
        }
    }
}
