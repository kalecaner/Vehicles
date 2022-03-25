using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.BLL.Abstract;
using Vehicles.Services.Abstract;

namespace Vehicles.BLL.Concrate
{
    public class BusService:IBusService
    {
        IBusRepository busRepository;
        public BusService(IBusRepository _busRepository)
        {
            busRepository = _busRepository;
        }

        public List<string> GetBusbyColor(string color)
        {
            return busRepository.GetBusByColor(color);
        }
    }
}
