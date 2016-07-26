using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using CitiesKata.EF.Entities;

namespace CitiesKata.EF.DbContext
{
    public class CitiesKataContext : System.Data.Entity.DbContext
    {
        public CitiesKataContext() : base("SchoolContext")
        {
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Attraction> Attractions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        //public void Seed()
        //{
        //    var attractions = new List<Attraction>()
        //    {
        //        new Attraction("Football"),
        //        new Attraction("Bars"),
        //        new Attraction("Music"),
        //        new Attraction("City Walls"),
        //        new Attraction("Cathedral"),
        //        new Attraction("Casinos"),
        //        new Attraction("Grand Canyon"),
        //        new Attraction("Shows"),
        //        new Attraction("Forbidden City"),
        //        new Attraction("Great Wall of China")
        //    };

        //    attractions.ForEach(attraction => Attractions.Add(attraction));
        //    SaveChanges();

        //    var countries = new List<Country>()
        //    {
        //        new Country("UK"),
        //        new Country("USA"),
        //        new Country("China")
        //    };

        //    countries.ForEach(country => Countries.Add(country));
        //    SaveChanges();

        //    var attractionsManc = new List<Attraction>()
        //    {
        //        Attractions.Single(x => x.Name == "Football"),
        //        Attractions.Single(x => x.Name == "Bars")
        //    };

        //    var attractionsLiv = new List<Attraction>()
        //    {
        //        Attractions.Single(x => x.Name == "Football"),
        //        Attractions.Single(x => x.Name == "Bars"),
        //        Attractions.Single(x => x.Name == "Music")
        //    };

        //    var attractionsYork = new List<Attraction>()
        //    {
        //        Attractions.Single(x => x.Name == "City Walls"),
        //        Attractions.Single(x => x.Name == "Cathedral")
        //    };

        //    var attractionsLasVegas = new List<Attraction>()
        //    {
        //        Attractions.Single(x => x.Name == "Casinos"),
        //        Attractions.Single(x => x.Name == "Grand Canyon"),
        //        Attractions.Single(x => x.Name == "Shows")
        //    };

        //    var attractionsBejing = new List<Attraction>()
        //    {
        //        Attractions.Single(x => x.Name == "Forbidden City"),
        //        Attractions.Single(x => x.Name == "Great Wall of China")
        //    };

        //    var cities = new List<City>()
        //    {
        //        new City("Manchester", Countries.Single(x => x.Name == "UK").Id, attractionsManc),
        //        new City("Liverpool", Countries.Single(x => x.Name == "UK").Id, attractionsLiv),
        //        new City("York", Countries.Single(x => x.Name == "UK").Id, attractionsYork),
        //        new City("Las Vegas", Countries.Single(x => x.Name == "USA").Id, attractionsLasVegas),
        //        new City("Bejing", Countries.Single(x => x.Name == "China").Id, attractionsBejing)
        //    };

        //    cities.ForEach(city => Cities.Add(city));
        //    SaveChanges();
        //}
    }
}
