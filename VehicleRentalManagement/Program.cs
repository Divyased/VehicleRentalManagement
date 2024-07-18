using System;
public class Program()
{
    public static void Main()
    {
        RentalAgency agency = new RentalAgency();
        Car c1 = new Car("Chevrolet Camaro", "Chevrolet", 2023, 150, 4, "V8", "Manual", false);
        Truck t1 = new Truck("RAM 1500", "RAM", 2022, 180, 3.0, "Pickup", true);
        Motorcycle mc1= new Motorcycle("Street 750", "Harley-Davidson", 2020, 110, 750, "Petrol", true);

        agency.AddVehicle(c1);
        agency.AddVehicle(t1);
        agency.AddVehicle(mc1);

        Console.WriteLine("Fleet details are:");
        Console.WriteLine("\n");
        agency.DisplayFleet();

        Console.WriteLine("\nRenting a vehicle:");
        agency.RentVehicle(c1);

        Console.WriteLine("\nAfter renting fleet details are:");
        Console.WriteLine("\n");
        agency.DisplayFleet();

        Console.WriteLine("\nTotal Revenue:" + "" + agency.TotalRevenue.ToString("C"));
    }
}