using _07_RepositoryPattern_Repository; //this is where you see which outisde file  is referenced in this file
using _08_StreamingContent_Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _09_StreamingContent_Console.UI
{
    public class ProgramUI
    {
        //creating a field so we have access to and can the repository within this 

        private readonly StreamingRepository _streamingRepo = new StreamingRepository();

        public void Run()
        {
            SeedContentList(); // place this here so it will add the seeded content before it runs the menu
            RunMenu();
        }

        private void CreateNewContent()
        {
            Console.Clear(); // clears all the content from the menu    end goal of method is to create an new content
            StreamingContent content = new StreamingContent(); //new instance of class StreamingContent named content
            //title
            Console.WriteLine("Please enter the title of the content:");
            content.Title = Console.ReadLine();

            //description
            Console.WriteLine("Please enter the description:");
            content.Description = Console.ReadLine();

            //maturityRating
            Console.WriteLine("Select a Maturity Rating: \n" +
                "1) G \n" +
                "2) PG \n" +
                "3) PG13 \n" +
                "4) R \n" +
                "5) NC17 \n" +
                "6) TV MA");
            string maturityString = Console.ReadLine();
            switch (maturityString)
            {
                case "1":
                    content.MaturityRating = MaturityRating.G;
                    break;
                case "2":
                    content.MaturityRating = MaturityRating.PG;
                    break;
                case "3":
                    content.MaturityRating = MaturityRating.PG_13;
                    break;
                case "4":
                    content.MaturityRating = MaturityRating.R;
                    break;
                case "5":
                    content.MaturityRating = MaturityRating.NC_17;
                    break;
                case "6":
                    content.MaturityRating = MaturityRating.TV_MA;
                    break;
            }

            //star rating
            Console.WriteLine("Please enter the star rating 1-100");
            double rating = Convert.ToDouble(Console.ReadLine()); // convert could handle a null were parse couldnt handle a null
            //double rating2 = double.Parse(Console.ReadLine()); // like casting parese the string in a double.

            //genre

            Console.WriteLine("Select a Genre \n" +
                "1: Horror \n" +
                "2: Sci-Fi \n" +
                "3: Drama \n" +
                "4: Action \n" +
                "5: Comedy \n" +
                "6: Ainme \n" +
                "7: Documentary \n" +
                "8: Thriller \n" +
                "9: Romance");  // must be in same order as enum

            string genreInput = Console.ReadLine();
            int genreID = int.Parse(genreInput);
            content.TypeOfGenre = (GenreType)genreID; // we are taking an integer and casting into a enum            Casting is taking one type and changing into another type   We are taking something and changing it from it state  what type you want it to be goes inside the paranthese and what it is currently goes outside and to the right
            _streamingRepo.AddContentToDirectory(content); // the streamingresporitory inherited from the streaming content repository thus we have the ability to use the method AddContentToDiretory and used the StreamingContent named content which is a local variable since we created and new instance/object of the type StreamingContent
        }

        private void ShowAllContent() 
        {
            Console.Clear();
            List<StreamingContent> listOfContents = _streamingRepo.GetContents();

            foreach(StreamingContent contentVariable in listOfContents)
            {
                DisplayContent(contentVariable);
                Console.WriteLine("------------------"); // makes lines in the code so it is easier to read.
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        private void ShowContentByTitle()
        {
            Console.Clear();
            Console.WriteLine("Enter a title");
            string title = Console.ReadLine();
            StreamingContent foundTitle = _streamingRepo.GetContentByTitle(title);

            if(foundTitle != null)// if title entered is found within the list   //if title is not found in the list it will return a null value
            {
                DisplayContent(foundTitle); //then display the foundTitle
            }

            else
            {
                Console.WriteLine("Invalid Title. Could not find any results.");
            }
            Console.ReadKey();
        } // if method is grayed out it is not being referenced

        private void RemoveContentFromList() //*?
        {
            Console.WriteLine("Which Title would you like to remove?");  // user prompt
            List<StreamingContent> contentList = _streamingRepo.GetContents();// do not have to new up a list because it is being assigned a value of an existing list
            int count = 1;
            foreach(StreamingContent content in contentList)
            {
                Console.WriteLine($"{count} { content.Title}"); //this writes the increased count integer followed by the title of the content item that corralates to that title in the content list;
                count++; // increase the count by 1
            }

            int targetContentId = int.Parse(Console.ReadLine());// users string input is saved as an integer variable title targetContentId
            int targetIndex = targetContentId - 1; //integer with the variable targetIndex is equal to the userinput -1

            if(targetIndex >= 0 && targetIndex < contentList.Count) // if the items left on the le is greater than or equal to zero and the number of items left on the list is lesss than the total count of items on the list
            {
                StreamingContent desiredContent = contentList[targetIndex]; // the object of the users entry is the number that of the user entered
                if (_streamingRepo.DeleteExistingContent(desiredContent)) // if the item from the content list was successfully deleted
                {
                    Console.WriteLine($"{desiredContent.Title} successfully removed.");// console Prints this message
                }
                else
                {
                    Console.WriteLine("Desired action cannot be preformed."); //else if the items were not successfully deleted console will print this line
                }
            }

            else
            {
                Console.WriteLine("No content meets criteria"); // else if the user inputs and invalid repsonse
            }
            Console.WriteLine("Press any key....");
            Console.ReadKey();
        
        }

        private void DisplayContent(StreamingContent content)
        {
            Console.WriteLine($"Title {content.Title} \n" +
                $"Description: {content.Description} \n" +
                $"Genre: {content.TypeOfGenre} \n" +
                $"Stars: {content.StarRating} \n" +
                $"Family Friendly: {content.IsFamilyFriendly} \n"+
                $"Maturity Rating: {content.MaturityRating}"
                );
        } 

        private void SeedContentList() // want this to content to run before your menu
        {
            StreamingContent movie1 = new StreamingContent("Back to the Future", "No description needed", MaturityRating.PG, 98, GenreType.Action);
            StreamingContent movie2 = new StreamingContent("Toy Story", "Toys have a life of their own", MaturityRating.G, 98, GenreType.Anitmated);
            StreamingContent movie3 = new StreamingContent("Lion King", "How is the head of the pride", MaturityRating.G, 98, GenreType.Anitmated);
            StreamingContent movie4 = new StreamingContent("Remember the Titans", "A football team changes the community at the beginning of desegregation", MaturityRating.PG_13, 98, GenreType.Drama);

            _streamingRepo.AddContentToDirectory(movie1);
            _streamingRepo.AddContentToDirectory(movie2);
            _streamingRepo.AddContentToDirectory(movie3);
            _streamingRepo.AddContentToDirectory(movie4);
        }

        private void RunMenu() //this creates path for the user but control what they see the user has no access to modify the content of this method
        {
            bool continueToRun = true;
            while (continueToRun)
            {


                Console.WriteLine(
                    "Enter the number of options you would like to select \n" +
                    "1. Show all streaming content \n" +
                    "2. Find streaming content by title \n" +
                    "3. Add new streaming content \n" +
                    "4. remove streaming content \n" +
                    "5. Exit");  // \n must fall within the quotation marks \n creates an newline

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case ("1"):
                        //find all
                        ShowAllContent();
                        break;
                    case ("2"):
                        //find by title
                        ShowContentByTitle();
                        break;
                    case ("3"):
                        //Add new
                        CreateNewContent();
                        break;
                    case ("4"):
                        //remove
                        RemoveContentFromList();
                        break;
                    case ("5"):
                        //exit
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number between 1 and 5. \n" +
                            "Press any key to continue.....");
                        Console.ReadKey();
                        break;
                }
            }
        }

    }
}
