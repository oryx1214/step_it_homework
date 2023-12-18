using AbstractFactory.Entitites.Classes;
using AbstractFactory.Entitites.Interfaces;
using AbstractFactory.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories;

class TruckVehicleFactory : IVehicleFactory
{
    public IEngine CreateEngine()
    {
        return new TruckEngine();
    }

    public IWheels CreateWheels()
    {
        return new TruckWheels();
    }
}