using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_SwitchCases
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 1;
            switch (input)
            {
                case 1:
                    Console.WriteLine("Hello");
                    break;
                case 2:
                    Console.WriteLine("What are you doing?");
                    break;
                default:
                    Console.WriteLine("This is default. It will execute if no other case  is evaluated.");
                    break;
            }

            //Stacking Switch Cases
            DayOfWeek today = DateTime.Today.DayOfWeek;
            switch (today)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    Console.WriteLine("Hope you are ready to work!");
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("Sorry we are closed.");
                    break;
            }

            //--Challenge
            //Ask the user how they are feeling on a scale of 1-5.
            //Capture their input and run it through a switch statement.
            //Output a differen response

            Console.WriteLine("On a scale of 1 - 5. How are you feeling today?");
            string feeling = Console.ReadLine();
            int num = Convert.ToInt32(feeling);

            switch (num)
            {
                case (5):
                    Console.WriteLine("That's terrific!");
                    break;
                case (4):
                    Console.WriteLine("That's good to hear");
                    break;
                case (3):
                    Console.WriteLine("I guess it could be worse.");
                    break;
                case (2):
                    Console.WriteLine("Oh No!");
                    break;
                case (1):
                    Console.WriteLine("That's the worst");
                    break;
                default:
                    Console.WriteLine("I am sorry that doesn't make sense");
                    break;
            }

            Console.WriteLine("Are you dressed");
            string dressed = Console.ReadLine();
            string answer = dressed.ToLower();

            switch (answer)
            {
                case ("yes"):
                case ("yep"):
                case ("almost"):
                case ("i am"):
                    Console.WriteLine("Great let's go!");
                    break;

                case ("no"):
                case ("why do i need to get dressed"):
                case ("not yet"):
                    Console.WriteLine("Hurry up and get dressed we've got to go!");
                    break;

                default:
                    Console.WriteLine("I don't understand what your are saying");
                    break;
                 
            }

            Console.ReadKey();
        }

    }
}
