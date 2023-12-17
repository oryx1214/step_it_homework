using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Dz.Interface;
namespace Dz.Class
{
    internal class Off_roader : IAutomobile
    {
        public string Mark { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public void GetModelInfo()
        {
            Console.WriteLine($"Off_roader information: Mark:{Mark}, Model:{Model}, Year:{Year}");
        }
    }
}
