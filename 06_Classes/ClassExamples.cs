using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Classes
{
    public enum VehicleType { Car, Truck, Van, Motorcycle, Plane, Spaceship, Boat, Submarine }
    public class Vehicle// blueprint for object-oriented programing is classes | Classes are abstract| Vehicle is the object and can be assigned details
    {
        public string Make { get; set; }//1 access modifier //2 type(property) 3//name
        public string Model { get; set; } //defualt of string is null
        public int Year { get; set; }
        public double Mileage { get; set; }

        public string Color { get; set; }
        public VehicleType TypeOfVehicle { get; set; }

        public Vehicle()
        {
            Year = 1990;
            Color = "default color";
        }


        public Vehicle(string make, string model, int year, double mileage, string color, VehicleType typeOfVehicle)//class method, built with placehoder

        {
            Make = make;
            Model = model;
            Year = year;
            Mileage = mileage;
            Color = color;
            TypeOfVehicle = typeOfVehicle;
        }
    }
    public class Person
    {
        public string FirstName { get; set; }
        private string _lastName;

        public string LastName
        {
            get { return _lastName; }// returns the property
            set { _lastName = value; }// sets the property = to a value
        }

        public string FullName
        { get { return $"{FirstName} {LastName}"; } }
        //returns the values of property first name and lastName but does not set the value of the property.
        public DateTime DateOfBirth { get; set; }

        public int AgeInYears
        {
            get
            {
                if (DateOfBirth == new DateTime())
                {
                    return 9001;
                }
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                double totalAgeInYears = ageSpan.TotalDays / 365.25;
                return Convert.ToInt32(Math.Floor(totalAgeInYears));
            }
        }

        //adding a class as a property of another class
        public Vehicle Transport { get; set; }

        public Person() { }
        public Person(string firstName, string lastName, DateTime birthday)// does not take FullName because FullName is returned but not set in the fullName method above
        {
            FirstName = firstName; //Property = value 
            LastName = lastName;//Property = value
            DateOfBirth = birthday;//Property = value

        }
    }
}
  


