
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
    public class CarConfig : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Arabalar");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Brand).IsRequired();
            builder.Property(a => a.WheelType).IsRequired();
            builder.Property(a => a.HeadlightType).IsRequired();
            builder.Property(a=>a.NumberPlate).IsRequired();



            //builder.HasData(new Car { Id = 2, Brand = "BMW", WheelType = "16X7J(31)5-120", HeadlightType = "Normal", NumberPlate = "ab11" });

        }
    }
}
