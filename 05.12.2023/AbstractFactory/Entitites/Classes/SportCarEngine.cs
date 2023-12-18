using AbstractFactory.Entitites.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Entitites.Classes;

class SpotrCarEngine: IEngine
{
    public void Start()
    {
        Console.WriteLine("Sports Car Engine is starting.");
    }
}