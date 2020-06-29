using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public class Sport
    {
        public string sportName { get; set; }
        public string[] equipment { get; set; }
        public int numberOfPlayers { get; set; }
        public int popularity { get; set; }
        public double lengthInMinutes { get; set; }
        public string halvesOrQuarters { get; set; }
        public Sport() { }
        public Sport(string sportname, string[] equipment2, int players, int popularity2, double length, string halvesorquarters)
        {
            sportName = sportname;
            equipment = equipment2;
            numberOfPlayers = players;
            popularity = popularity2;
            lengthInMinutes = length;
            halvesOrQuarters = halvesorquarters;

        } // must fall inside of the class 


    }

    public enum CandyBrand { Wonka, Mars, Haribo, Hershey }

    public class Candy //when setting class for the first time you don't set the class with paranthese before the body
    {
        public string Flavor { get; set; }
        public string Color { get; set; }
        public double Cost { get; set; }
        public CandyBrand Brand { get; set; }

        public Candy(string flavor, string color, double cost, CandyBrand brand) // must fall within the class it is referencing
        {
            Flavor = flavor;
            Color = color;
            Cost = cost;
            Brand = brand;

        }

        public Candy() { }// so the class "Candy" can take either properties or parameters
    }

    public enum CookieType { Snickerdoodle, Chocolate_Chip, Sugar, Oatmeal_Raisin, Peanut_Butter, Oatmeal_Chooclate_Chip, Snowballs}// enums values should be Pascal cased
    public class Cookie
    {
        public CookieType Type { get; set }
        public double Cost { get; set; }
        public int NumberOfCoolkies { get; set; }
        public bool IsItGood { get; set; }


        public Cookie(CookieType type, double cost, int number, bool good)
        {
            Type = type;// this sets the propert equal to the value of the parameter
            Cost = cost;//this sets the property equal to the value of the parameter
            NumberOfCoolkies = number;//the sets the property equal to the value of the parameter
            IsItGood = good;//this sets the property equal to the value of the parameter
        }  

        public Cookie() { }
    }


    public enum Subsidiary
    {
        Pixar,
        LucasFlims,
        Marvel,
        DisneyAnimation,
        NationalGeographic,
        Simpsons
    }

    public enum Type
    {
        LiveAction,
        Animation,
        Documentary,
    }

    public class Disney
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string MaturityRating { get; set; }
        public  double StarRating { get; set; }
        public double LengthInMinutes { get; set; }
        public Subsidiary Company { get; set; }
        public Type ContentType { get; set; }

        public Disney() { }

        public Disney(string title, string description, string audinceRating, double rating, double length, Subsidiary company, Type type) 
        {
            Title = title;
            Description = description;
            MaturityRating = audinceRating;
            StarRating = rating;
            LengthInMinutes = length;
            Company = company;
            ContentType = type;
        }
    }

    
}

  


