
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Entity.Entities.Enums;
using Vehicles.Entity.Interfaces;

namespace Vehicles.Entity
{
    public class Car : Vehicle, IWheel,IHeadlight
    {
     
        public string WheelType { get; set ; }
        public string HeadlightType { get; set ; }
        public OnOff IsOn { get ; set; }
    }
}
