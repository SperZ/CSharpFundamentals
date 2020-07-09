using AdventureGame_Library1;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame_Console.UI
{

    public class AdventureGameUI
    {
        private readonly AdventureGame_Repository _adventureRepo = new AdventureGame_Repository();
        protected readonly Character newCharacter = new Character();

        public void Run()
        {
            RunMenu();
        }

        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine(
                    "Enter the number of options you would like to select \n" +
                    "1. Start a New Game \n" +
                    "2. Exit");  // \n must fall within the quotation marks \n creates an newline

                string userInput = Console.ReadLine();

               switch (userInput)
               {
                    case ("1"):
                        //Starts A New Game
                        StartNewGame();
                        break;
                    case ("2"):
                        //exit
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number either 1 or 2 \n" +
                            "Press any key to continue.....");
                        Console.ReadKey();
                        break;
                }
            }

        }

        private void StartNewGame()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the World Schuka a text based adventure. Please have fun and follow the prompts.\n" + "When asked to select between numberous items. \n" + "Please enter the number corresponding to what item you would like to choose.\n" + "Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Enter the number of the character type you would like to choose \n" +
                "1) Elf \n" +
                "2) Knight \n" +
                "3) Mage \n" +
                "4) Dwarf \n" +
                "5) Ranger");
            string number = Console.ReadLine();
            switch (number)
            {
                case "1":
                    newCharacter.CharacterType = TypeOfCharacter.Elves;
                    break;
                case "2":
                    newCharacter.CharacterType = TypeOfCharacter.Knight;
                    break;
                case "3":
                    newCharacter.CharacterType = TypeOfCharacter.Mage;
                    break;
                case "4":
                    newCharacter.CharacterType = TypeOfCharacter.Dwarf;
                    break;
                case "5":
                    newCharacter.CharacterType = TypeOfCharacter.Ranger;
                    break;
                default:
                    Console.WriteLine("The character type you have choosen is invalid. A character has been chosen for you");
                    newCharacter.CharacterType = TypeOfCharacter.Bard;
                    Console.ReadKey();
                    break;

            }
            Console.Clear();
            Console.WriteLine("Choose a weapon \n" +
                "1) Sword \n" +
                "2) Bow \n" +
                "3) Axe \n");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    newCharacter.Weapon = "sword";
                    break;
                case "2":
                    newCharacter.Weapon = "bow";
                    break;
                case "3":
                    newCharacter.Weapon = "axe";
                    break;
                default:
                    Console.WriteLine("The weapon you have selected is invalid. The weapon will be chosen for you");
                    newCharacter.Weapon = "Lute";
                    Console.ReadKey();
                    break;
            }
            Console.Clear();
            Console.WriteLine($"Your character is a {newCharacter.CharacterType} your weapon type is {newCharacter.Weapon}. You have {newCharacter.Health} health \n" + "Press a key to continue on your adventure.");
            Console.ReadKey();

            _adventureRepo.AddCharacterToList(newCharacter);

            Console.Clear();
            Console.WriteLine("Name the monster you would like to face.");
            Monster newMonster = new Monster();
            newMonster.Name = Console.ReadLine();
            Console.WriteLine("What type of Monster would you like to face? \n" +
                "1) Boss Monster \n" +
                "2) Demigorgon \n" +
                "3) Your Arch Nemesis");
            int i =int.Parse(Console.ReadLine());
            switch (i) 
            {
                case 1:
                    newMonster.MonsterType= "Boss Monster";
                    break;
                case 2:
                    newMonster.MonsterType = "Demigorgon";
                    break;
                case 3:
                    newMonster.MonsterType= "Your Arch Nemesis";
                    break;
                default:
                    Console.WriteLine("The Monster type you have choosen is unavaiable at this time. A default Monster has been chosen for you.");
                    newMonster.MonsterType = "Nightmare";
                    break;
                       
            }

            _adventureRepo.AddMonsterToList(newMonster);

            

            Console.Clear();
            Console.WriteLine($"Your monsters name is and {newMonster.Name} is of type {newMonster.MonsterType}.\n" + "Press any key to continue.");
            Console.ReadKey();

            Console.Clear();
        

            bool isinputCorrect = false;
            Console.WriteLine("You wake up in a dark room lit only by a small candle on the bedside table. You try to open the door but it is locked. You will need to find a key to get it. Where would you like to search? \n" +
                 "1) Under the bed \n" +
                 "2) In the closet \n" +
                 "3) In the desk drawer");
            int guess = Convert.ToInt32(Console.ReadLine());

            do
            {  
                if (guess == 3)
                {
                    isinputCorrect = true; // breaks the loop
                    Console.WriteLine("You found the correct key");

                }
                else // program continues to run until program is over
                {
                    Console.WriteLine("You didn't find the key ... try again");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
            }
            while (!isinputCorrect);

            Console.Clear();
            Console.WriteLine("You unlock the door and walk out of the village in the corner of your eye you spot a stranger hunched over in desperate need of help? \n" +
                "1) Yes \n"+
                "2) No");
            int userInput = int.Parse(Console.ReadLine());
            if (userInput == 1)
            {
                Console.WriteLine("The man is very thankful and such you have gained an extra life");
                newCharacter.Health++;
                Console.WriteLine($"Congrats you now have {newCharacter.Health} health.");

            }
            else if (userInput == 2)
            {
                Console.WriteLine("The man has cried out for help and no has answered thus he is left in a pool of tears \n" +"You slip in the tears");
                newCharacter.Health--;
                Console.WriteLine($"Sorry you now have {newCharacter.Health} health.");
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("The road reaches a split there are two paths - one to the right and one to the left. Which do you choose? \n" +
                "1) Right \n" +
                "2) Left");
            int userInput2 = int.Parse(Console.ReadLine());

           

            if (userInput2 == 1)// problem here
            {
                bool isinputCorrect1 = false;
                Console.WriteLine("Your path is blocked by a bear! What do you do? \n" +
                    "1) Run \n" +
                    $"2) Draw your {newCharacter.Weapon}. \n");
                int choice1 = int.Parse(Console.ReadLine());

                do
                {
                    if (choice1 == 2)
                    {
                        isinputCorrect1 = true; // breaks the loop
                        newCharacter.Health++;
                        Console.WriteLine("You kill the bear after a hard battle.");

                    }
                    else // program continues to run until program is over
                    {
                        Console.WriteLine("You weren't able to get away. You must press 2 to fight back!");
                        newCharacter.Health -= 2;
                        choice1 = int.Parse(Console.ReadLine());
                    }
                }
                while (!isinputCorrect1);
            }

            else if (userInput2 == 2)
            {
                Console.WriteLine("Your path is blocked by a goblin! How do you react? \n" + "");
            }

            Console.Clear();
            Console.WriteLine($"You now have {newCharacter.Health} health.");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("It is getting late so you turn back for home.\n" + $"On your way home you are stopped by{newMonster.Name} a {newMonster.MonsterType} \n" );

            if(newCharacter.Health >= newMonster.Health)
            {
                Console.WriteLine($"Hurray you defeated {newMonster.Name} \n" + "You make it back home safely and head straight for bed worn out for the days adventure");
            }
            else
            {
                Console.WriteLine($"{newMonster.Name} has defeated you. GAME OVER!");
            }
            Console.ReadKey();

        }
    }

}


