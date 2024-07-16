using System;
using System.Collections.Generic;

public class RentalAgency
{
    private List<Vehicle> Fleet { get; set; }
    public decimal TotalRevenue { get; private set; }
    public RentalAgency()
    {
        Fleet = new List<Vehicle>();
        TotalRevenue = 0;
    }
    public void AddVehicle(Vehicle vehicle)
    {
        Fleet.Add(vehicle);
    }
    public void RemoveVehicle(Vehicle vehicle)
    {
        Fleet.Remove(vehicle);
    }
    public void RentVehicle(Vehicle vehicle)
    {
        if (Fleet.Contains(vehicle))
        {
            TotalRevenue += vehicle.RentalPrice;
            Fleet.Remove(vehicle);
            Console.WriteLine(vehicle.Model + " " + "has been rented");
        }
        else
        {
            Console.WriteLine(vehicle.Model + " " + " is not available");
        }
    }
    public void DisplayFleet()
    {
        foreach (var vehicle in Fleet)
        {
            vehicle.DisplayDetails();
            Console.WriteLine();
        }
    }
}