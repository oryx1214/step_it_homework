using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state;
class RedState : ITrafficLightState
{
    public void Handle(TrafficLight trafficLight)
    {
        Console.WriteLine("Red Light: to brake");
        trafficLight.SetState(new GreenState());
    }
}
