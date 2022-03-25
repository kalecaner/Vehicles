using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.BLL.Abstract
{
    public interface IBusService
    {
        List<string> GetBusbyColor(string color);
    }
}
