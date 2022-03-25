using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Entity;

namespace Vehicles.Services.Abstract
{
    public interface IBusRepository
    {
        List<string> GetBusByColor(string color);
        Bus checkNumberPlateForCBus(string numberPlate);
    }
}
