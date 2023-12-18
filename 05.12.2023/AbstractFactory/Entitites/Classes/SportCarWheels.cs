using AbstractFactory.Entitites.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Entitites.Classes;

class SportsCarWheels : IWheels
{
    public void Rotate()
    {
        Console.WriteLine("Sports Car Wheels are rotating.");
    }
}