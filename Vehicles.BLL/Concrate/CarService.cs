using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.BLL.Abstract;
using Vehicles.Services.Abstract;

namespace Vehicles.BLL.Concrate
{
   public class CarService: ICarService
    {
        ICarRepository carRepository;
        public CarService(ICarRepository _carRepository)
        {
            carRepository = _carRepository;

        }

        public int Delete(string brand)
        {
             return carRepository.DeleteByBrand(brand);
        }

        public List<string> GetCarbyColor(string color)
        {
            return carRepository.GetCarByColor(color);
        }

        public bool IsThereCar(string brand)
        {
            if (carRepository.CountCarByBrand(brand))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        

        public string TurnHeadLightofVehicle(string numberPlate)
        {


            return carRepository.checkIsOnOrOff(numberPlate);
        }

      
    }
}
