using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_Classes
{
    [TestClass]
    public class ClassTests
    {
        [TestMethod]
        public void VehiclePropertyTest()



        {
            //create new instance
            Vehicle firstVehicle = new Vehicle();// Vehicle is the class and we are making the object firstVehicle of class vehicle
            // using to access differnt properties
            firstVehicle.Color = "White"; // vehicle porperty color is set to white. property is Color. firstVehicle is the object we are assigning the property of white to.
            Console.WriteLine(firstVehicle.Color);
            firstVehicle.Make = "Cadillac";
            firstVehicle.Model = "DTS";
            firstVehicle.Mileage = 7;
            firstVehicle.Year = 2018;
            firstVehicle.TypeOfVehicle = VehicleType.Car;
            string carDetails = $"{firstVehicle.Make} {firstVehicle.Mileage}";
            Console.WriteLine(carDetails);

            Vehicle myVehicle = new Vehicle();
            myVehicle.Year = 2025;

            Vehicle rocket = new Vehicle("SpaceX", "Falcon Heavy", 2019, 9000, "white", VehicleType.Spaceship);
            //constructors allow us in one line to create a new instance of vehicle and then assign values to the all the properties of the instance vehicle. instead of calling each value one at a time we created a constructor to assign values to all the properties. vehicle rocket= new (instanceof)Vehicle (make, model, year, mileage, color, and vehicle type) Constructors  are class methods

            //C# | Constructors. A constructor is a special method of the class which gets automatically invoked whenever an instance of the class is created. Like methods, a constructor also contains the collection of instructions that are executed at the time of Object creation.

            Vehicle wrongV = new Vehicle("Purple", "Toyota", 2, 22, "Vera", VehicleType.Submarine);
            Vehicle testV = new Vehicle();

        }

        [TestMethod]
        public void PersonTests()
        {
            Person myPerson = new Person("Appa", "YipYip", new DateTime(2001, 06, 11));
            Console.WriteLine(myPerson.AgeInYears);
            Console.WriteLine(myPerson.FullName);

            // vehicle is a class with the property of transport inside the calss of Person

            Person newPerson = new Person("Zuko", "FireLord", new DateTime(1990, 06, 22));// created new instance of person with the property values
            newPerson.Transport = new Vehicle("Pontiac", "FireBird", 1989, 100123, "Red and Gold", VehicleType.Car);//created new vehicle property for the instance of new person
            Console.WriteLine(newPerson.Transport.Model);

            Assert.AreEqual("Zuko FireLord", newPerson.FullName);
        }
    }

   
 
}
