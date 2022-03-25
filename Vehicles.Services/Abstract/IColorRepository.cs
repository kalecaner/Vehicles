using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Services.Abstract
{
    public interface IColorRepository
    {
        int GetColorIdByColor(string color);
    }
}
