// See https://aka.ms/new-console-template for more information
using state;
class Program
{
    static void Main()
    {
        TrafficLight trafficLight = new TrafficLight();
        trafficLight.ChangeState(); //Красный потом Зеленый
        trafficLight.ChangeState(); //Зеленый потом Желтый
        trafficLight.ChangeState(); //Желтый потом Красный
    }
}