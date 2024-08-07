﻿using System;
public class Car:Vehicle
{
    public int Seats { get; set; }
    public string EngineType { get; set; }
    public string Transmission { get; set; }
    public bool Convertible { get; set; }
    public Car(string model, string manufacturer, int year, decimal rentalprice, int seats, string enginetype, string transmission, bool convertible): base(model,manufacturer,year,rentalprice)
    {
        Seats = seats;
        EngineType = enginetype;
        Transmission = transmission;
        Convertible = convertible;
    }
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Seats:" + " " + Seats);
        Console.WriteLine("Engine Type:" + " " +  EngineType);
        Console.WriteLine("Transmission:" + " " +  Transmission);
        Console.WriteLine("Convertible:" + " " +  Convertible);
    }
}
