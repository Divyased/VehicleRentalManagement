using System;

public class Truck : Vehicle
{
    public double Capacity { get; set; }
    public string TruckType { get; set; }
    public bool FourWheelDrive { get; set; }
    public Truck(string model, string manufacturer, int year, decimal rentalprice, double capacity,string trucktype, bool fourwheeldrive) : base(model,manufacturer,year,rentalprice) 
    { 
        Capacity = capacity;
        TruckType = trucktype;
        FourWheelDrive = fourwheeldrive;
    }
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Capacity:" + " " +  Capacity);
        Console.WriteLine("Truck Type:" + " " + TruckType);
        Console.WriteLine("Four Wheel Drive:" + " " +  FourWheelDrive);
    }
}

