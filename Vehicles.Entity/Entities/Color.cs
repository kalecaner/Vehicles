using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Entity.Entities.Interfaces;

namespace Vehicles.Entity.Entities
{
    public class Color:IId
    {
        public int Id { get ; set; }
        public string ColorType { get; set; }
       

    }
}
