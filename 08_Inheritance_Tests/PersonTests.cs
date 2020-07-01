using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using _08_Inheritance_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_Inheritance_Tests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void SetName_ShouldSetCorrectly()
        {
            Person martha = new Person();// martha is a new person object
            martha.PhoneNumber = "8675309"; //with martha we only have access to person class properties
            Console.WriteLine(martha.PhoneNumber);

            Customer bob = new Customer();
            bob.PhoneNumber = "123-1234"; // because bob is set up as customer you have access to every property of customer plus every property inherited from the person class

            SalaryEmployee ted = new SalaryEmployee
            {
                PhoneNumber = "fakenumber", // with ted we have access to all the properties of the salaryemployee class plus all the properties it inherited from the employee class and all the properties that the employee class inherited from person
                Salary = 120000,
                HireDate = new DateTime(1304, 1, 1), // must be followed by comma and not semi colon  //refernce type must always be proceeded with new if you are creating a new instance
            };

            Console.WriteLine(ted.YearsWithCompany); // must be within a method and not oustide method in class
        }

        [TestMethod]
        public void CustomerIsPremium_ShouldGetCorrectBool()
        {
            //setting up actual testMethod utilizing a new  thing/instance
            Customer firstCustomer = new Customer();
            firstCustomer.IsPremium = true;
            Person newPerson = new Person();
            Console.WriteLine(newPerson.GetType()); // this will get which class that this instance belongs to.
            Console.WriteLine(firstCustomer.GetType()); // this will get which class that this instance belongs to.
            Assert.IsTrue(firstCustomer.IsPremium);
        }

        [TestMethod]
        public void EmployeeTests()
        {
            Employee jarvis = new Employee();// newing up new instance of the employee class named jarvis
            HourlyEmployee tony = new HourlyEmployee(); // new instance of the hourly employee class named tony
            SalaryEmployee pepper = new SalaryEmployee(); //new instance of salary employee class named pepper
            tony.HoursWorked = 55;
            tony.HourlyWage = 9003;
            pepper.Salary = 200000;

            List<Employee> allEmployees = new List<Employee>();
            allEmployees.Add(jarvis);
            allEmployees.Add(tony);
            allEmployees.Add(pepper); //adds all these employess to the list of employees
            //tony.Name = "Tony Stark"
            tony.SetFirstName("Tony");// sets the property of the first name and the field _firstName
            tony.SetLastName("Stark");// sets the property of the last name and the field _LastName

            foreach(Employee worker in allEmployees) //iterates through the list loops through this list and reassigns the variable worker each time the loop reaches the start of the list the list so first time through it is assigned the variable of jarvis, second time through the list it is assigned the values of tony, last time through the list it is assigned the value of pepper. Once it has run through the all the employees in the allemployee list the program stops. 
            {
                if(worker.GetType() == typeof(SalaryEmployee)) // if worker is a salaryEmployee //will run through jarvis, tony, and pepper because they are all within the list of allemployees
                {
                    SalaryEmployee sEmployee = (SalaryEmployee)worker;
                    Console.WriteLine($"this is a salary employee that makes {sEmployee.Salary}"); // ?
                }
                else if(worker is HourlyEmployee hourlyWorker) // pattern matching it is taking worker turning into hourly worker then creating new variable within the if statement
                {
                    //HourlyEmployee hEmployee = (HourlyEmployee)hourlyWorker;
                    Console.WriteLine($"{worker.Name} has worked {hourlyWorker.HoursWorked} hours!");
                }
            }
        }

    }
}
