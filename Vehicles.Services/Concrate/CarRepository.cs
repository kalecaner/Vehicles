using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Entity;
using Vehicles.Entity.Entities.Enums;
using Vehicles.Services.Abstract;

namespace Vehicles.Services.Concrate
{
    public class CarRepository : ICarRepository
    {
        VehiclesDbContext DbContext;
        IColorRepository ColorRepository;
        IBusRepository BusRepository;
        IBoatRepository BoatRepository;

        public CarRepository(VehiclesDbContext _VehiclesDb, IColorRepository _ColorRepository, IBusRepository _BusRepository,
        IBoatRepository _BoatRepository)
        {
            DbContext = _VehiclesDb;
            ColorRepository = _ColorRepository;
            BusRepository = _BusRepository;
            BoatRepository = _BoatRepository;
        }

        public string checkIsOnOrOff(string numberPlate)
        {
            Car car = checkNumberPlateForCar(numberPlate);
            if (car != null)
            {
                
                if (car.IsOn == OnOff.on)
                {
                    car.IsOn = OnOff.off;
                    DbContext.Update(car);
                    DbContext.SaveChanges();
                    return "off";
                }
                else if (car.IsOn == OnOff.off)
                {
                    car.IsOn = OnOff.on;
                    DbContext.Update(car);
                    DbContext.SaveChanges();
                    return "on";
                }
            }
            else if (car == null)
            { Bus bus= new Bus();
                bus = BusRepository.checkNumberPlateForCBus(numberPlate);
                if (bus != null)
                {

                    if (bus.IsOn == OnOff.on)
                    {
                        bus.IsOn = OnOff.off;
                        DbContext.Update(bus);
                        DbContext.SaveChanges();
                        return "off";
                    }
                    else if (bus.IsOn == OnOff.off)
                    {
                        bus.IsOn = OnOff.on;
                        DbContext.Update(bus);
                        DbContext.SaveChanges();
                        return "on";
                    }
                }
                else if (car == null)
                {Boat boat=new Boat();
                     boat = BoatRepository.checkNumberPlateForCBus(numberPlate);
                    if (boat != null)
                    {

                        if (boat.IsOn == OnOff.on)
                        {
                            boat.IsOn = OnOff.off;
                            DbContext.Update(boat);
                            DbContext.SaveChanges();
                            return "off";
                        }
                        else if (boat.IsOn == OnOff.off)
                        {
                            boat.IsOn = OnOff.on;
                            DbContext.Update(boat);
                            DbContext.SaveChanges();
                            return "off";
                        }
                    }


                }
              
            }
            return "Plaka bulunamadı";
        }

        private Car checkNumberPlateForCar(string numberPlate)
        {
           return DbContext.Cars.Where(c => c.NumberPlate == numberPlate).FirstOrDefault();
        }

        public bool CountCarByBrand(string brand)
        {
           return DbContext.Cars.Any(c => c.Brand == brand);
        }

        public int DeleteByBrand(string brand)
        {
          int WillDeleteBrand=DbContext.Cars.Where(c=>c.Brand==brand).Select(c=>c.Id).SingleOrDefault();
            DbContext.Remove(WillDeleteBrand);
            return  DbContext.SaveChanges();
        }

        public List<string> GetCarByColor(string color)
        {

            int ColorId =ColorRepository.GetColorIdByColor(color);

            return DbContext.Cars.Where(a => a.Color.Id == ColorId).Select(a => a.Brand).ToList();



        }

        
    }
}
