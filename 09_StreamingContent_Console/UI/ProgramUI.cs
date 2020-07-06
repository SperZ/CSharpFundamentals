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
        private readonly IConsole _console;


        private readonly StreamingRepository _streamingRepo = new StreamingRepository();

        public ProgramUI(IConsole console) // this tells the programUI what what type of console to implement 
        {
            _console = console;
        }
        public void Run()
        {
            SeedContentList(); // place this here so it will add the seeded content before it runs the menu
            RunMenu();
        }

        private void RunMenu() //this creates path for the user but control what they see the user has no access to modify the content of this method
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                _console.Clear();
                _console.WriteLine(
                    "Enter the number of options you would like to select \n" +
                    "1. Show all streaming content \n" +
                    "2. Find streaming content by title \n" +
                    "3. Add new streaming content \n" +
                    "4. remove streaming content \n" +
                    "5. Exit");  // \n must fall within the quotation marks \n creates an newline

                string userInput = _console.ReadLine();
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
                        continueToRun = false;
                        break;
                    default:
                        _console.WriteLine("Please enter a valid number between 1 and 5. \n" +
                            "Press any key to continue.....");
                        _console.ReadKey();
                        break;
                }
            }
        }



        private void CreateNewContent()
        {
            _console.Clear(); // clears all the content from the menu    end goal of method is to create an new content
            StreamingContent content = new StreamingContent(); //new instance of class StreamingContent named content
            //title
            _console.WriteLine("Please enter the title of the content:");
            content.Title = _console.ReadLine(); //sets the title of the streaming object to whatever the user inputs

            //description
            _console.WriteLine("Please enter the description:");
            content.Description = _console.ReadLine(); // sets the description of the streaming object to whatever the user inputs

            //maturityRating
            _console.WriteLine("Select a Maturity Rating: \n" +
                "1) G \n" +
                "2) PG \n" +
                "3) PG13 \n" +
                "4) R \n" +
                "5) NC17 \n" +
                "6) TV MA");
            string maturityString = _console.ReadLine(); // takes in the string then uses the string in a switch statement to set the streaming object maurityrating
            switch (maturityString)
            {
                case "1":
                    content.MaturityRating = MaturityRating.G; // the streaming objects maturity rating will be equal to the MaturityRating.G
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
            _console.WriteLine("Please enter the star rating 1-100");
            double rating = Convert.ToDouble(_console.ReadLine()); // convert could handle a null were parse couldnt handle a null
            //double rating2 = double.Parse(_console.ReadLine()); // like casting parese the string in a double.

            //genre

            _console.WriteLine("Select a Genre \n" +
                "1: Horror \n" +
                "2: Sci-Fi \n" +
                "3: Drama \n" +
                "4: Action \n" +
                "5: Comedy \n" +
                "6: Ainme \n" +
                "7: Documentary \n" +
                "8: Thriller \n" +
                "9: Romance");  // must be in same order as enum

            string genreInput = _console.ReadLine();
            int genreID = int.Parse(genreInput);
            content.TypeOfGenre = (GenreType)genreID; // we are taking an integer and casting into a enum            Casting is taking one type and changing into another type   We are taking something and changing it from it state  what type you want it to be goes inside the paranthese and what it is currently goes outside and to the right
            _streamingRepo.AddContentToDirectory(content); // the streamingresporitory inherited from the streaming content repository thus we have the ability to use the method AddContentToDiretory and used the StreamingContent named content which is a local variable since we created and new instance/object of the type StreamingContent
        }

        private void ShowAllContent() 
        {
            _console.Clear();
            List<StreamingContent> listOfContents = _streamingRepo.GetContents(); // stores all contents in the the streaming repository in a list called listoftcontents with type StreamingContent

            foreach(StreamingContent contentVariable in listOfContents) //foreach 
            {
                DisplayContent(contentVariable);
                _console.WriteLine("------------------"); // makes lines in the code so it is easier to read.
            }

            _console.WriteLine("Press any key to continue");
            _console.ReadKey();
        }

        private void ShowContentByTitle()
        {
            _console.Clear();
            _console.WriteLine("Enter a title");
            string title = _console.ReadLine();
            StreamingContent foundTitle = _streamingRepo.GetContentByTitle(title);

            if(foundTitle != null)// if title entered is found within the list   //if title is not found in the list it will return a null value
            {
                DisplayContent(foundTitle); //then display the foundTitle
            }

            else
            {
                _console.WriteLine("Invalid Title. Could not find any results.");
            }
            _console.WriteLine("Press any key to continue");
            _console.ReadKey();
        } // if method is grayed out it is not being referenced


        private void RemoveContentFromList() //*?
        {
            _console.WriteLine("Which Title would you like to remove?");  // user prompt
            List<StreamingContent> contentList = _streamingRepo.GetContents();// do not have to new up a list because it is being assigned a value of an existing list
            int count = 0;
            foreach(StreamingContent content in contentList)
            {
                count++; // increase the count by 1
                _console.WriteLine($"{count} { content.Title}"); //this writes the increased count integer followed by the title of the content item that corralates to that title in the content list;
            }

            int targetContentId = int.Parse(_console.ReadLine());// users string input is saved as an integer variable title targetContentId
            int targetIndex = targetContentId - 1; //integer with the variable targetIndex is equal to the userinput -1 thus an entry of three grabs the item number 2 because the count starts at 0

            if(targetIndex >= 0 && targetIndex < contentList.Count) // if the targeted item is greater than or equal to zero and the number of items left on the list is greater than the total count of items on the list it will move to the 
            {
                StreamingContent desiredContent = contentList[targetIndex]; // the object of the users desires to be remove is the idexed number in the content list. Which would be the number the user enter -1
                if (_streamingRepo.DeleteExistingContent(desiredContent)) // if the item from the content list was successfully deleted
                {
                    _console.WriteLine($"{desiredContent.Title} successfully removed.");// console Prints this message
                }
                else
                {
                    _console.WriteLine("Desired action cannot be preformed."); //else if the items were not successfully deleted console will print this line
                }
            }

            else
            {
                _console.WriteLine("No content meets criteria"); // else if the user inputs and invalid repsonse
            }
            _console.WriteLine("Press any key....");
            _console.ReadKey();
        
        }

        private void DisplayContent(StreamingContent content)
        {
            _console.WriteLine($"Title {content.Title} \n" +
                $"Description: {content.Description} \n" +
                $"Genre: {content.TypeOfGenre} \n" +
                $"Stars: {content.StarRating} \n" +
                $"Family Friendly: {content.IsFamilyFriendly} \n"+
                $"Maturity Rating: {content.MaturityRating}"
                );
        } 

        private void SeedContentList()  // want this to content to run before your menu
        {
            StreamingContent movie1 = new StreamingContent("Back to the Future", "Man travels back in time", MaturityRating.PG, 98, GenreType.Action);
            StreamingContent movie2 = new StreamingContent("Toy Story", "Toys have a life of their own", MaturityRating.G, 98, GenreType.Anitmated);
            StreamingContent movie3 = new StreamingContent("Lion King", "How is the head of the pride", MaturityRating.G, 98, GenreType.Anitmated);
            StreamingContent movie4 = new StreamingContent("Remember the Titans", "A football team changes the community at the beginning of desegregation", MaturityRating.PG_13, 98, GenreType.Drama);

            _streamingRepo.AddContentToDirectory(movie1);
            _streamingRepo.AddContentToDirectory(movie2);
            _streamingRepo.AddContentToDirectory(movie3);
            _streamingRepo.AddContentToDirectory(movie4);
        }

       

    }
}
