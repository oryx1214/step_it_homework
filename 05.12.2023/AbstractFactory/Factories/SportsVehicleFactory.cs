using AbstractFactory.Entitites.Classes;
using AbstractFactory.Entitites.Interfaces;
using AbstractFactory.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories;

class SportsVehicleFactory : IVehicleFactory
{
    public IEngine CreateEngine()
    {
        return new SportsCarEngine();
    }

    public IWheels CreateWheels()
    {
        return new SportsCarWheels();
    }
}

