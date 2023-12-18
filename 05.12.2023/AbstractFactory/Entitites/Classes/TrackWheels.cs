using AbstractFactory.Entitites.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Entitites.Classes;

class TruckWheels : IWheels
{
    public void Rotate()
    {
        Console.WriteLine("Truck Wheels are rotating.");
    }
}
