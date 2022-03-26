
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Entity.Entities;
using Vehicles.Entity.Entities.Enums;

namespace Vehicles.Entity.EntityConfig
{
    public class BoatConfig : IEntityTypeConfiguration<Boat>
    {
        public void Configure(EntityTypeBuilder<Boat> builder)
        {

            builder.ToTable("Yatlar");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Brand).IsRequired();
            builder.Property(a => a.HeadlightType).IsRequired();
            builder.Property(a => a.NumberPlate).IsRequired().IsUnicode();
            builder.Property(a => a.IsOn).IsRequired().HasConversion<int>();
           




        }
    }
}
