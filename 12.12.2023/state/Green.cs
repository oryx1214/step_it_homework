using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state;
class GreenState : ITrafficLightState
{
    public void Handle(TrafficLight trafficLight)
    {
        Console.WriteLine("Green Light: go");
        trafficLight.SetState(new YellowState());
    }
}
