

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Entity.Entities;
using Vehicles.Entity.Entities.Interfaces;

namespace Vehicles.Entity
{
   public class Vehicle:IId
    {     
        public int Id { get ; set ; }
        public string Brand { get; set ; }
        public int MaxSpeed { get; set; }
        public int EnginePower { get; set; }
        public string NumberPlate { get; set; }
        
        public virtual Color Color { get; set; }

    }
}
