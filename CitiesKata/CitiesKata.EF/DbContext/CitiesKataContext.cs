using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
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
    }
}
