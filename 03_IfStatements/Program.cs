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
            Console.ReadLine();
        }
    }
}
