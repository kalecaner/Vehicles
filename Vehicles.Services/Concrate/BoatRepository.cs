using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Entity;
using Vehicles.Services.Abstract;

namespace Vehicles.Services.Concrate
{
    public class BoatRepository:IBoatRepository
    {
        VehiclesDbContext DbContext;
        IColorRepository ColorRepository;

        public BoatRepository(VehiclesDbContext _VehiclesDb, IColorRepository _ColorRepository)
        {
            DbContext = _VehiclesDb;
            ColorRepository = _ColorRepository;
        }

        public Boat checkNumberPlateForCBus(string numberPlate)
        {
            return DbContext.Boats.Where(c => c.NumberPlate.ToLower().Trim() == numberPlate).FirstOrDefault();
        }

        public List<string> GetBoatbyColor(string color)
        {
           int ColorId=ColorRepository.GetColorIdByColor(color);
            if (ColorId > 0)
            {
            return DbContext.Boats.Where(a => a.Color.Id==ColorId).Select(a=>a.Brand).ToList();

            }
            else
            {
                return null;
            }

        }
    }
}
