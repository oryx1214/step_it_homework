using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dz.Interface;
namespace Dz.Class
{
    internal class Truck : IAutomobile
    {
        public string Mark { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public void GetModelInfo()
        {
            Console.WriteLine($"Truck information: Mark:{Mark}, Model:{Model}, Year:{Year}");
        }
    }
}
