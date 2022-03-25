
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
    public class BusConfig : IEntityTypeConfiguration<Bus>
    {
        public void Configure(EntityTypeBuilder<Bus> builder)
        {
            builder.ToTable("Otobüsler");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Brand).IsRequired();
            builder.Property(a => a.WheelType).IsRequired();
            builder.Property(a => a.HeadlightType).IsRequired();
            builder.Property(a => a.NumberPlate).IsRequired();


            ////builder.HasData(new Car { Id = 3, Brand = "Mercedes", WheelType = "16X21J(31)5-120", HeadlightType = "Led", IsOn = OnOff.off, NumberPlate = "ab13"});
        }
    }
}
