using System;
public class Program()
{
    public static void Main()
    {
        RentalAgency agency = new RentalAgency();
        Car car1 = new Car("Chevrolet Camaro", "Chevrolet", 2023, 150, 4, "V8", "Manual", false);
        Truck truck1 = new Truck("RAM 1500", "RAM", 2022, 180, 3.0, "Pickup", true);
        Motorcycle motorcycle1= new Motorcycle("Street 750", "Harley-Davidson", 2020, 110, 750, "Petrol", true);

        agency.AddVehicle(car1);
        agency.AddVehicle(truck1);
        agency.AddVehicle(motorcycle1);

        Console.WriteLine("Fleet details are:");
        agency.DisplayFleet();

        Console.WriteLine("\nRenting a vehicle:");
        agency.RentVehicle(car1);

        Console.WriteLine("\nAfter renting fleet details are:");
        agency.DisplayFleet();

        Console.WriteLine("\nTotal Revenue:" + "" + agency.TotalRevenue.ToString("C"));
    }
}