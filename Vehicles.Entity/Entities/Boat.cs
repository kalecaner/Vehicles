using Vehicles.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Entity.Entities.Enums;

namespace Vehicles.Entity
{
    public class Boat : Vehicle,IHeadlight
    {
        
        public string HeadlightType { get ; set; }
        public OnOff IsOn { get ; set ; }
       
    }
}
