using System;

public class Motorcycle : Vehicle
{
    public int EngineCapacity { get; set; }
    public string FuelType { get; set; }
    public bool HasFairing { get; set; }
    public Motorcycle(string model, string manufacturer, int year, decimal rentalprice, int enginecapacity, string fueltype, bool hasfairing) : base(model,manufacturer,year,rentalprice) 
    {
        EngineCapacity = enginecapacity;
        FuelType = fueltype;
        HasFairing = hasfairing;
    }
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Engine Capacity:" + " " +  EngineCapacity + "cc");
        Console.WriteLine("Fuel Type:" + " " +  FuelType);
        Console.WriteLine("Has Fairing:" + " "+  HasFairing);
    }
}