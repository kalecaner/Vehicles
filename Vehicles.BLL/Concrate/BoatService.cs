using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.BLL.Abstract;
using Vehicles.Services.Abstract;


namespace Vehicles.BLL.Concrate
{
    public class BoatService: IBoatService
    {
        IBoatRepository boatRepository;
       
        public BoatService(IBoatRepository _boatRepository)
        {
            boatRepository = _boatRepository;
        }

        public List<string> GetBoatbyColor(string color)
        {
            return boatRepository.GetBoatbyColor(color);
        }
    }
}
