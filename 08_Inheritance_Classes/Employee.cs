using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance_Classes
{
    public class Employee : Person   // child class : parent class   // can only inherit from one class            
    {
        public int EmployeeNumber { get; set; }
        public DateTime HireDate { get; set; }
        public int YearsWithCompany
        {
            get
            {                           //timespan occur whenever you are dealing with two DateTimes
                double totalTime = (DateTime.Now - HireDate).TotalDays/ 365.25;
                return Convert.ToInt32(Math.Floor(totalTime)); // uses the built in class of math and the built in floor method and rounds it to the nearest  then converts to integer
            }
        }
    }

    public class HourlyEmployee : Employee //inherits from employee class which would also inherit from person claas
    {
        public decimal HourlyWage { get; set; }
        public double HoursWorked { get; set; }
    }

    public class SalaryEmployee : Employee //salaryEmployee child class inherits from employee parent class
    {
        public decimal Salary { get; set; }
    }
    
}