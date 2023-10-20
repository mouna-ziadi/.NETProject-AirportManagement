using AM.Core.Domain;
using AM.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Data
{
    public class AMContext:DbContext
    {
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Traveller> Travellers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
                                                     Initial Catalog = Airport;
                                                     Integrated Security = true");
            optionsBuilder.UseLazyLoadingProxies();
        }

        //tp4 Q 6

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlaneConfig());
            modelBuilder.ApplyConfiguration(new FlightConfig());
            modelBuilder.ApplyConfiguration(new PassengerConfig());
            
            //TP5 Q3
           // modelBuilder.Entity<Staff>().ToTable("Staffs");
           // modelBuilder.Entity<Traveller>().ToTable("Travellers");

            modelBuilder.ApplyConfiguration(new ReservationConfig());
        }

        //tp4 Q8

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<DateTime>()
                .HaveColumnType("date");
            
        }




    }
}
