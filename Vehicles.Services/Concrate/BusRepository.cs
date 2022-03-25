using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Entity;
using Vehicles.Services.Abstract;

namespace Vehicles.Services.Concrate
{
    public class BusRepository:IBusRepository
    {
        VehiclesDbContext DbContext;
        IColorRepository ColorRepository;


        public BusRepository(VehiclesDbContext _VehiclesDb, IColorRepository ColorRepository )
        {
            DbContext = _VehiclesDb;
            ColorRepository = ColorRepository;
            
        }

        public Bus checkNumberPlateForCBus(string numberPlate)
        {
            return DbContext.Buses.Where(c => c.NumberPlate == numberPlate).FirstOrDefault();
        }

        public List<string> GetBusByColor(string color)
        {
          
              int ColorId=ColorRepository.GetColorIdByColor(color);
            return DbContext.Buses.Where(a=>a.Color.Id==ColorId).Select(a=>a.Brand).ToList();

        }
            
    }
}
