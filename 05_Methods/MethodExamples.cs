using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Methods
{
    [TestClass]
    public class MethodExamples
    {
        public void SayHello(string name)// Mehtod Name should be say what it is doing to so it is clear to use and other viewers
        {
            Console.WriteLine($"Hello, {name}!");// gives us the ability to tap in any name we want
        }
        [TestMethod]
        //1) Access Modifier = public
        //2) Return Type = void
        //3) Method Signature made up of method name and parameters which fall inside(variable type variable name)
        //4) Body- the code that gets executed
        public void MethodExecution()
        {
            SayHello("Erick");
            SayHello("Harry");

            int inputOne = 7;
            int inputTwo = 13;
            int sum = AddTwoNumber(inputOne, inputTwo);
            Console.WriteLine(sum);
            double doubleSum = AddTwoNumber(242.2d, 234.5d);


            int myAge = CalculateAge(new DateTime(1989, 03, 10));
            Console.WriteLine("My age is:" + myAge);

            //to run open test explorer (right click and select debug test and use search test bar to open lowest heirarchy and click open additional output

            //methods on the same line same scope cant talk to each other, stuff built in one method cant be used in other methods. However stuff declared/built outside the method in class which encompasses the method can be used in the method that is nested inside of it.
        }

        public int AddTwoNumber(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        public  double AddTwoNumber(double one, double two)
        {
            double sum = one + two;
            return sum;
        }

        private int CalculateAge(DateTime birthday)
        {
            TimeSpan ageSpan = DateTime.Now - birthday;
            double totalAgeInYears = ageSpan.TotalDays / 365.25;
            int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return years;
        }
    }
}
