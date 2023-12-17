using Dz.Class;
using Dz.Factory;
using Dz.Interface;

IAutomobileFactory Sedan = new SedanFactory();
IAutomobileFactory off_Roader = new Dz.Factory.Off_roader();
IAutomobileFactory Truck = new TruckFactory();


IAutomobile sedan = Sedan.CreateAutomobile();
IAutomobile off_roader = off_Roader.CreateAutomobile();
IAutomobile truck = Truck.CreateAutomobile();

sedan.GetModelInfo();
off_roader.GetModelInfo();
truck.GetModelInfo();


