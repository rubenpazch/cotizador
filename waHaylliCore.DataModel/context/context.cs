using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using waHaylliCore.EntityModel;

namespace waHaylliCore.DataModel
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("HaylliCoreContext") {

        }

        public DbSet<City> cities { get; set; }
        public DbSet<Currency> currencies { get; set; }
        public DbSet<Price> prices { get; set; }
        public DbSet<PriceRate> priceRates { get; set; }
        public DbSet<Rate> rates { get; set; }
        public DbSet<Service> services { get; set; }
        public DbSet<ServiceType> serviceTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }

    }
}
