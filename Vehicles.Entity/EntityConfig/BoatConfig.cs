
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
            builder.Property(a => a.NumberPlate).IsRequired();
           


            //builder.HasData(new Car { Id = 1, Brand = "Oggusto", HeadlightType = "Led", IsOn = OnOff.off ,NumberPlate="ab12" });

        }
    }
}
