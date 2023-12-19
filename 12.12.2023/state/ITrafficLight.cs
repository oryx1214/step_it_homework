using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state;
interface ITrafficLightState
{
    void Handle(TrafficLight trafficLight);
}
