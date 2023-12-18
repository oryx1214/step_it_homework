using AbstractFactory.Entitites.Interfaces;
using AbstractFactory.Factories.Classes;
using AbstractFactory.Factories.Interfaces;

Console.WriteLine("Building Sports Car:");
var sportsClient = new Client(new SportsVehicleFactory());
sportsClient.BuildVehicle();

Console.WriteLine("\nBuilding Truck:");
var truckClient = new Client(new TruckVehicleFactory());
truckClient.BuildVehicle();
