// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using NeedForSpeed;

var car = RemoteControlCar.Nitro();

RemoteControlCar car1 = new RemoteControlCar(20, 10);

car1.Drive();
car1.DistanceDriven();
car1.BatteryDrained();

int racetrackDistance = 500;

RaceTrack raceTrack = new RaceTrack(racetrackDistance);

Console.WriteLine(raceTrack.TryFinishTrack(car1));

Console.ReadLine();
