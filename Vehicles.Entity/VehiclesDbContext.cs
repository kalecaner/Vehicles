using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Entity;
using Vehicles.Entity.Entities;
using Vehicles.Entity.EntityConfig;

namespace Vehicles.Services
{
    public class VehiclesDbContext:DbContext
    {
        public VehiclesDbContext(DbContextOptions<VehiclesDbContext> options) : base(options)
        {
         
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Boat> Boats { get; set; }
        public DbSet<Color> Colors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BoatConfig());
            modelBuilder.ApplyConfiguration(new CarConfig());
            modelBuilder.ApplyConfiguration(new BusConfig());
        }

    }
}
