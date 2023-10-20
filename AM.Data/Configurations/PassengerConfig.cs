using AM.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AM.Data.Configurations
{
    internal class PassengerConfig : IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {   //TP4 Q13
            builder.OwnsOne(p => p.MyFullName,
                fn =>
                {
                    fn.Property(fn => fn.FirstName).HasMaxLength(30)
                    .HasColumnName("Name");
                    fn.Property(fn => fn.LastName).IsRequired();
                }
                );
            // TP5 Q1
            /*
            builder.HasDiscriminator<int>("IsTraveller")
                .HasValue<Traveller>(1)
                .HasValue<Staff>(2)
                .HasValue<Passenger>(0);  
            */

        }
    }
}
