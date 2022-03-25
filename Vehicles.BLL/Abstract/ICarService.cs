using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.BLL.Abstract
{
    public interface ICarService
    {
        List<string> GetCarbyColor(string color);
        bool IsThereCar(string brand);
        int Delete(string brand);
       
        string TurnHeadLightofVehicle(string numberPlate);
    }
}
