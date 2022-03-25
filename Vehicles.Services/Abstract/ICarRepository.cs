using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Entity;

namespace Vehicles.Services.Abstract
{
    public interface ICarRepository
    {
        List<string> GetCarByColor(string color);
        bool CountCarByBrand(string brand);
        int DeleteByBrand(string brand);
        string checkIsOnOrOff(string numberPlate);
    }
}
