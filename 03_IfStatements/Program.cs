using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userIsHungry = true;
            if (userIsHungry)
            {
                Console.WriteLine("Eat Something!");
            }

            int hoursSpentStudying = 1;
            if (hoursSpentStudying < 16)
            {
                Console.WriteLine("Are you even trying?");
            }

            bool chorseAreDone = false;
            if (chorseAreDone)
            {
                Console.WriteLine("Have fin playing video games.");
            }
            else
            {
                Console.WriteLine("Finish your chores!");
            }

            //Nested if statements
            Console.WriteLine("How many hours did you sleep?");
            string input = Console.ReadLine();
            int totalHours = int.Parse(input);

            if(totalHours >= 8)
            {
                Console.WriteLine("Congrats. You are living the dream!");
            }
            else
            {
                Console.WriteLine("Are you a night owl?");
                if(totalHours < 3)
                {
                    Console.WriteLine("Get some sleep");
                }
            }

            Console.WriteLine("How old are you");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            if(age > 17)
            {
                Console.WriteLine("Congrats on being an adult!");
            }
            else
            {
                if (age > 6)
                {
                    Console.WriteLine("You are a kiddo");
                }
                else if(age > 0)
                {
                    Console.WriteLine("You are just a baby.");
                }
                else
                {
                    Console.WriteLine("Are you even born yet?!");
                }

            }

            if(age >65 || age < 18)
            {
                Console.WriteLine("You have entereed and age greater than 65 or less than 18.");
            }
            

            Console.WriteLine("How much money do you make?");
            string money = Console.ReadLine();
            int i = Convert.ToInt32(money);

            if ((i >= 1000) && (i <= 10000))
            {
                Console.WriteLine("Don't worry your windfall is coming soon.");
            }
            else if (i >= 11000 && i <= 50000)
            {
                Console.WriteLine("Life can be rough");
            }
            else if (i >= 51000 && i <= 100000)
            {
                Console.WriteLine("Thats a good earning.");
            }
            else if(i < 1000)
            {
                Console.WriteLine("Do you have a job?");
            }
            else
            {
                Console.WriteLine("You are rich");
            }


                bool isHappy = true;
            Console.WriteLine("Are you happy");
            string answer = Console.ReadLine();
            if(answer == "yes")
            {
                Console.WriteLine(isHappy);
            }
            else
            {
                Console.WriteLine("They are not happy!");
            }

            int x = 1;
            while (x < 100)
            {
                if (x % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (x % 5 == 0)
                {
                    Console.WriteLine("Fizz");
                }

                else if (x%3 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(x);
                }
                x++;

            }


            Console.WriteLine("What is your name?");
            string response = Console.ReadLine();
            string name = response.ToLower();

            switch (name)
            {
                case ("asher"):
                case ("reagan"):
                case ("nate"):
                case ("annalisa"):
                    Console.WriteLine("You live at 8495 Abernathy Lane.");
                    break;

                case ("linda"):
                case ("tad"):
                case ("alice"):
                case ("emeryk"):
                    Console.WriteLine("You live on Grant Street.");
                    break;

                case ("sheri"):
                case ("tom"):
                case ("gigi"):
                case ("zach"):
                case ("poo pa"):
                    Console.WriteLine("You live at 7702 Sherry Lane.");
                    break;

                case ("brittany"):
                    Console.WriteLine("You live on Eaker Court.");
                    break;

                default:
                    Console.WriteLine("You live in a box.");
                    break;

            }

            Console.ReadLine();
        }
    }
}
