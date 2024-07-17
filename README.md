PROJECT DESCRIPTION

The project is all about designing and implementing the Vehicle Rental Management System using the object oriented principles. There are 5 classes in the project Vehicle, Car, Truck, Motorcycle and Rentalagency.

1. Vehicle.cs
   - In this class, properties like model, manufacturer, year and rental price are created.
   - And also a method called DisplayDetails() is also implemented to display the details.

2. Car.cs
   - This class will be inherited from vehicle class.
   - Some additional details has also been added which is specific to a car such as Seats, Engine type, Transmission and Convertible
   - Overrided Displaydetails() method which will display the details of the car.
   - Includes both vehicle and car properties

3. Truck.cs
   - This class will be inherited from vehicle class.
   - Truck details such as Capacity, Truck type, and Four wheel drive has been added
   - Overrided Displaydetails() method which will display the details of the truck.
   - Includes both vehicle and truck properties

4. Motorcycle.cs
   - This class will be inherited from vehicle class.
   - Motorcycle specific details are added EngineCapacity, FuelType, and HasFairing
   - Overrided Displaydetails() method which will display the details of the motorcycle.
   - Includes both vehicle and motorcycle common properties

5. RentalAgency.cs
   - This class will include the fleet details of the vehicle
   - TotalRevenue property is included to track the revenue earned by agencies.
   - Methods to add vehicles, remove vehicles and rent vehicles has also been implemented.
   
And there is a main method called Program.cs where all the functionalities of the classes have been displayed.

SET UP INSTRUCTIONS

1. Clone the repository
2. Open the project in the Visual Studio
3. Build the project
4. Run the application (Execute Program.cs file)
