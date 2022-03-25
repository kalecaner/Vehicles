using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Entity.Entities;

namespace Vehicles.Entity.EntityConfig
{
    internal class ColorConfig : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.ToTable("Renkler");
            builder.HasKey(a => a.Id);

            //builder.HasData(new Color { Id = 1, ColorType = "Beyaz" });
            //builder.HasData(new Color { Id = 2, ColorType = "Mavi" });
            //builder.HasData(new Color { Id = 3, ColorType = "Kırmızı" });


        }
    }
}
