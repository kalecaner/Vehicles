using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.BLL.Abstract;
using Vehicles.Services.Abstract;

namespace Vehicles.BLL.Concrate
{
    public class ColorService:IColorService
    {
        IColorRepository ColorRepository;

        public ColorService(IColorRepository _ColorRepository)
        {ColorRepository = _ColorRepository;
            
        }
    }
}
