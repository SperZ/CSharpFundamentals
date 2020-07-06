using System;
using System.Collections.Generic;
using _09_StreamingContent_Console;
using _09_StreamingContent_Console.UI;
using _10_StreamingContent_UIRefractorTests.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _10_StreamingContent_UIRefractorTests
{
    [TestClass]
    public class ProgramUITests
    {
        [TestMethod]
        public void GetList_OutputShouldContainList()
        {
            // Arrange 
            List<string> commandList = new List<string> { "1", "5" }; // anything we given to get the ouput we need plus the exist, this tells the program to show 1 then close 5
            MockConsole console = new MockConsole(commandList); // in order to you need to pass in the IEnumerable into the new istance of mock console called command list
            ProgramUI program = new ProgramUI(console);  // you must tell the program ui what type of console you want it to run in this case the mockconsole  console is the console of choic

            //Act
            program.Run();
            Console.WriteLine(console.Output);

            //Assert
            Assert.IsTrue(console.Output.Contains("Back to the Future")); // This way we can see that the output we put in contains something we believe it should contain if it does it should pass as true
        }

        [TestMethod]
        public void AddToList_ShouldSeeItemInList()
        {
            //Arrange
            var customDesc = "This is my custom description"; // var can be used for any variable type as long as whats on the otherside of the equal sign gives it enough context
            var commandList = new List<string> { "3", "Title", customDesc, "4", "1", "8", "1", "5" }; // passing in prompts all prompts the programUI will need-------any readline you want to make sure you are providing an answer. 3 is add content, input title, add the custom description, 4 ist maturity rating, 8 is genre, 1 will show all content, and 5 will exit the program
            var console = new MockConsole(commandList);
            var ui = new ProgramUI(console);

            //Act
            ui.Run();
            Console.WriteLine(console.Output);

            //Assert
            Assert.IsTrue(console.Output.Contains(customDesc));
        }

        [TestMethod]
        public void RemoveFromList_ShouldSeeRemovedMessage()
        {
            //Arrange
            var commandList = new List<string> { "4", "2", "1", "5" };// the command list are the commands you are giving the UI to execute in the order you have given it.
            var console = new MockConsole(commandList);
            var ui = new ProgramUI(console);

            //Act
            ui.Run();
            Console.WriteLine(console.Output);

            //Assert
            Assert.IsFalse(console.Output.Contains("Toys have a life of their own"));
        }

        [TestMethod]
        public void FindStreamingContentByTitle_ShouldSeeContent()
        {
            //Arrange  //command list needed  //console needed //ui
            var title = "Back to the Future";
            var commandList = new List<string> { "2", title, "5" }; // callling the second case in Program UI which is to find contents by title, Entering the Title variable we set as the user input, then at the end choosing to exit the program----------could also use var fakeUserInput = 
            var console = new MockConsole(commandList); // this sets the console we are running to be the mock console we created
            var ui = new ProgramUI(console); // the program ui will choose to run the mock console we choose for it to run

            //Act  //runinng the program
            ui.Run(); // runs the program
            Console.WriteLine(console.Output);

            //Assert
            Assert.IsTrue(console.Output.Contains("Man travels back in time"));


        }
        

    }
}
