using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestionsDay3
{
    class Program
    {
        enum RestaurantItems { Brisket, Burgers, Fries, Coleslaw, PotatoSalad, Ribs, SmokedChicken, } // Enum variable and types should always be PascalCased and not camelCased
        static void Main(string[] args)
        {
            string restaurantName = "B's Briskets and Burgers";
            string food1 = "brisket";
            double food1price = 5.95d;
            double sidePrice = 1.75d;
            int numberofFood = 5;
            decimal totalCost = 29.75m;
            bool isFoodGood = true;
            bool doTheyServeTacos = false;
            Console.WriteLine(restaurantName);
            Console.WriteLine(food1);
            Console.WriteLine(food1price);
            Console.WriteLine(sidePrice);
            Console.WriteLine(numberofFood);
            Console.WriteLine(totalCost);
            Console.WriteLine(isFoodGood);
            Console.WriteLine(doTheyServeTacos);

            RestaurantItems order1 = RestaurantItems.Brisket;
            RestaurantItems sideOrder1 = RestaurantItems.Fries;
            //reference types

            //composite
            string color = "gold";
            string welcomeMessage = string.Format("Welcome {0} star member you have been granted {0} access to premium services.", color);
            string spamEmail = string.Format("Click on the box below to recieve all the {0} you could want. {0} is increasing in value everyday. So get all the {0} while you still can.", color);
            string randomMessage = string.Format("I have six {0} teeth. How many {0} teeth do you have?", color);
            Console.WriteLine(welcomeMessage);
            Console.WriteLine(spamEmail);
            Console.WriteLine(randomMessage);

            //interporlation
            string cheese = "string cheese";
            string pasta = "mac and cheese";
            string beans = "kidney beans";
            string randomSentence = $"I love my girlfriend as much as I like {pasta}, I am not sure she feels the same way. But she keeps {cheese}ing me along. I was like, You have to be {beans} not to love me back!";
            Console.WriteLine(randomSentence);

            //concatenation
            string word = "Hello";
            string concatenated = word + " world! " + word + " class! Welcome to the Gold Badge.";
            //composite
            string composite = string.Format("{0} World! {0} Class! Welcome to the Gold Badge", word);
            //interporlation
            string interpolated = $"{word} World! {word} Class! Welcome to the Gold Badge.";
            Console.WriteLine(concatenated);
            Console.WriteLine(composite);
            Console.WriteLine(interpolated);

            //Array
            char[] charArray = { 'l', 'm', 'z', 'p', 't' };
            Console.WriteLine(charArray[2]);

            //lists
            List<string> listOfFruits = new List<string>();// how do I add more than item to a list at a time, is there a special way to alphabitize them with out doing it manually, also can you print to console more than one list itme at a time, how is that done.
            listOfFruits.Add("apple");
            listOfFruits.Add("lemon");
            listOfFruits.Add("mango");
            listOfFruits.Add("pineapple");
            listOfFruits.Add("rasberry");
            listOfFruits.Add("strawberries");

            Console.WriteLine(listOfFruits[1]);


            //operators
            int a = 42;
            int b = 5;
            //multiplication
            int product = a * b;
            //addition
            int addition = a + b;
            //division
            int division = a * b;
            //double addition
            int sum1 = a + b + b;
            int sum2 = a + a + b;
            //elaborate operators
            int additon1 = a + b * 2;
            int sum3 = a * 2 + b;

            //bool day comparison skipped

            //Conditionals

            //if
            Console.WriteLine("How many hours did you sleep");
            int sleep = Convert.ToInt32(Console.ReadLine());

            if (sleep <= 8)
            {
                Console.WriteLine("I am tired");


            }
            if (sleep >= 20)
            {
                Console.WriteLine("Are you in a coma");
            }

            //if-else
            bool carIsOn = true;
            bool carHasGas = true;

            if (carIsOn)
            {
                if (carHasGas)
                {
                    Console.WriteLine("Let the Adventure Begin");
                }

            }
            else // can never have condition, however more if statements can be nested inside of it
            {
                if ((carIsOn != true) || (carHasGas != true))
                {
                    Console.WriteLine("Looks like your aren't going anywhere.");
                }
            }

            Console.WriteLine("What Hogwarts house do you belong to?");
            string answer = Console.ReadLine();
            string hogwartsHouse = answer.ToLower();//converts string answer to lower case

            //switch
            switch (hogwartsHouse)
            {
                case ("hufflepuff"):
                    Console.WriteLine("That's nice you belong to Hufflepuff");
                    break;
                case ("slytherin"):
                    Console.WriteLine("You dirty scoundrel");
                    break;
                case ("ravenclaw"):
                    Console.WriteLine("You are a raven");
                    break;
                case ("Gryffindor"):
                    Console.WriteLine("Have you met ................ Harry");
                    break;
                default:
                    Console.WriteLine("You dont belong to any house? How sad.");
                    break;
            }

            //ternaries
            int volumeLevel = 5;
            string volume = (volumeLevel == 10) ? "Turn volume down" : "Turn volume up";
            Console.WriteLine(volume);


            bool canSee = true;
            string visibility = (canSee == true) ? "Turn lights off" : "Turn lights on";
            Console.WriteLine(visibility);



            //Loops

            int num = 0;
            while (num < 50)//while check condition, while condition is true 
            {
                if ((num % 2) != 0)
                {
                    Console.WriteLine(num);
                }
                num++;// increments should not be within if condition in while loops they must be while condition but below the if condition
            }
            //this example checks the while condition to see if it is true, then checks the (if condition) if (if condition) is met then it writes to the console the number. if not it skips down to num++ and adds a number rechecks while condition to see if it is true if it is true goes back to if condition. if while condition is not true the loop stops.

            //for loops
            for (int num2 = 0; num2 < 50; num2 += 5) // (starting value, condition, what is done at the end of each loop)
            {
                Console.WriteLine(num2);
            }


            //foreach loop
            double[] niceNumbers = { 5d, 42d, 3d, 3d, 3d, 3, 3d, 3.14159d };
            foreach (double number in niceNumbers) // (new variable | collection type )
            {
                Console.WriteLine(number);
            }

            //do while loops (do whiles loop at least once, then checks to see if while condition is still true if so it loops until while condtions result is false.)
            int whileCondition = 0;
            do
            {
                Console.WriteLine("The console is finished");
            }
            while (whileCondition > 1);

            int iterator = 0;
            do
            {
                Console.WriteLine("Hurray for cheeseburgers");
                iterator++;

            }
            while (iterator < 10);



        }



        public string WelcomeGreeting(string name)
        {
            return $"{name}, how are you today";
        }

        public int myAge(int age)
        {
            return age;
        }

        public string myAge(string age)
        {
            return age;
        }





        // create a method that returns each char of a string
        public void LetterPrinter(string word)
        {
            foreach (char letter in word)
            {
                Console.WriteLine(letter);
            }
            
        }

       
        //creates a method that sorts a list of strings
        public List<string> ReturnSortedList()
        {
            List<string> quesodilla = new List<string>();
            quesodilla.Sort();

            return quesodilla;

        }

        //create a method that sorts a list of integers smallest to biggest
        //public List<int> BiggieSmalls()
        //{
        //    List<int> listBefore = new List<int>();
        //    List<int> listAfter = listBefore.Sort();

        //    return listAfter;
        //}


        public int StringToInt(string x)
        {
            Console.WriteLine("Input a string");
            string taco = Console.ReadLine();
            int nacho = taco.Length;

            return nacho;
        }

        create method that returns that takes a list of strings and returns without any vowels
        public List<string> GetByLetterNoVowels(List<string> x)
        {
            List<string> letters = new List<string>();
            foreach (char bowl in letters)
            {
                if (bowl != "a" || bowl != "e" || bowl != "i" || bowl != "o" || bowl != "u")
                {
                    letters.Add(Convert.ToString(bowl));
                }
            }

            if (letters.Count > 0)
            {
                return letters;
            }

            else
            {
                return null;
            }
        }


        // create a method that takes a user input string and outputs the reverse
        public string OutPutReverse(string word)
        {
            string grape = Console.ReadLine();
            List<char> apple = new List<char>();
            foreach (char c in grape)
            {
                apple.Add(c);

            }
            apple.Reverse();
            return Convert.ToString(apple);

            Console.ReadKey();

        }


    }
}
