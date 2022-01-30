using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        // Domain Entities
        public DbSet<Courier> Couriers { get; set; }

        public DbSet<ParcelDimensionsPricing> ParcelDimensionsPricing { get; set; }

        public DbSet<ParcelWeightPricing> ParcelWeightPricing { get; set; }

        public DbSet<Package> Packages { get; set; }
    }
}
