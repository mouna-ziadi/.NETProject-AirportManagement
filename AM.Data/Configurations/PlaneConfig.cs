﻿using AM.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;




namespace AM.Data.Configurations
{

    //tp4 Q 4

    internal class PlaneConfig : IEntityTypeConfiguration<Plane>
    {
        public void Configure(EntityTypeBuilder<Plane> builder)
        {
            builder.ToTable("MyPlanes")
                .Property(p => p.Capacity).HasColumnName("PlaneCapacity");
            builder.HasKey(p => p.PlaneId);



        }
    }
}
