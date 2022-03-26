using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Services.Abstract;

namespace Vehicles.Services.Concrate
{
    public class ColorRepository:IColorRepository
    {
        VehiclesDbContext DbContext;

        public ColorRepository(VehiclesDbContext _VehiclesDb)
        {
            DbContext = _VehiclesDb;
        }

        public int GetColorIdByColor(string color)
        {
            int Result=0;
            Result= DbContext.Colors.Where(a => a.ColorType.ToLower().Trim() == color).Select(a => a.Id).SingleOrDefault();
            return Result;
        }
    }
}
