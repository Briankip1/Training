// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using NeedForSpeed;

var car = RemoteControlCar.Nitro;

int distance = 100;

RaceTrack raceTrack = new RaceTrack(distance);

raceTrack.TryFinishTrack(car);


