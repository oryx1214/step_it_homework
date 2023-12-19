using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state;
class TrafficLight
{
    private ITrafficLightState state;

    public TrafficLight()
    {
        state = new RedState();
    }
    public void SetState(ITrafficLightState state)
    {
        this.state = state;
    }

    public void ChangeState()
    {
        state.Handle(this);
    }
}