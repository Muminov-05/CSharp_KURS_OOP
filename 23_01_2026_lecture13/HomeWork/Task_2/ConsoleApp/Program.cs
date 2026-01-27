

using Domain.Models;
using Infrastructure.Services;
using System.Diagnostics;

List<LightCar> cars = new List<LightCar>();
List<Truck> trucks = new List<Truck>();
List<CargoPlane> cargoPlane = new List<CargoPlane>();
List<PassengerPlane> passengerPlanes = new List<PassengerPlane>();
TrainServices trainServices = new TrainServices();


LightCarServices lightCarServices = new LightCarServices();
TruckServices truckServices = new TruckServices();
CargoPlaneServices cargoPlaneServices = new CargoPlaneServices();
PassengerPlaneServices passengerPlaneServices = new PassengerPlaneServices();


cars.Add(new LightCar("Toyota", 180, "Новый", "Toyota", "Белый"));
cars.Add(new LightCar("BMW X6", 240, "Новый", "BMW", "Черный"));
trucks.Add(new Truck("Volvo", 120, "Новый", "Volvo", "10T"));

cargoPlane.Add(new CargoPlane("Boeing 737", 750, "Грузовой самолёт", "8T", "50m"));
passengerPlanes.Add(new PassengerPlane("Сомон", 950, "Пассажирский самолёт", 40));

var train1 = new Train("Ozodi", 100, 200);
var train2 = new Train("Ozod", 120, 150);
var listTrain = new List<Train> { train1, train2 };

Console.WriteLine("Легковые авто:");
foreach (var car in cars)
    lightCarServices.PrintInfo(car);

Console.WriteLine("Грузовые авто:");
foreach (var truck in trucks)
    truckServices.PrintInfo(truck);

Console.WriteLine("Грузовой самолёт");
foreach( var pl in cargoPlane)
    cargoPlaneServices.PrintInfo(pl);

Console.WriteLine("Поезд");
foreach (var ps in passengerPlanes)
    passengerPlaneServices.PrintInfo(ps);

foreach( var tr in listTrain)
    trainServices.PrintTrainInfo(tr);