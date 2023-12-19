using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state;

class YellowState : ITrafficLightState
{
    public void Handle(TrafficLight trafficLight)
    {
        Console.WriteLine("Yellow Light: prepare to brake");
        trafficLight.SetState(new RedState());
    }
}