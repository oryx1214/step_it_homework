using Dz.Class;
using Dz.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz.Factory
{
    internal class SedanFactory : IAutomobileFactory
    {
        public IAutomobile CreateAutomobile()
        {
            return new Sedan { Mark = "Bmw", Model = "M5", Year = 2015 };
        }
    }
}
