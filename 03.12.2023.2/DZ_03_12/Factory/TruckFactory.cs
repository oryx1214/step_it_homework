using Dz.Class;
using Dz.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz.Factory
{
    internal class TruckFactory : IAutomobileFactory
    {
        public IAutomobile CreateAutomobile()
        {
            return new Truck { Mark = "Volvo", Model = "F88-49T", Year = 1970};
        }
    }
}
