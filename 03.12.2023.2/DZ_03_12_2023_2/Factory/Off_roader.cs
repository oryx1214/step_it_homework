using Dz.Class;
using Dz.Interface;

namespace Dz.Factory
{
    internal class off_Roader : IAutomobileFactory
    {
        public IAutomobile CreateAutomobile()
        {
            return new Off_roader { Mark = "Bmw", Model = "X5", Year = 2006 };
        }
    }
}
