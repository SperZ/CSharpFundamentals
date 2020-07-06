using _09_StreamingContent_Console.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_StreamingContent_UIRefractorTests.UI
{
    public class MockConsole : IConsole 
    {
        public Queue<string> UserInput;// this takes a list of strings passe
        public string Output;
        public MockConsole(IEnumerable<string> input) // IEnumberable a generic list of content, when this method is called it takes in the commands that are passed into the console.
        {
            UserInput = new Queue<string>(input); // this takes
            Output = ""; // this starts the output as blank
        }
        public void Clear()
        {
            Output += "Called Clear Method\n";  // this outputs a message everytime this method is closed
            //Output = Output = "Called Clear Method\n"
        }
        public ConsoleKeyInfo ReadKey()
        {
            return new ConsoleKeyInfo();
        }

        public string ReadLine() // we are taking input from user // it will take whatever is next in line
        {
            return UserInput.Dequeue();
        }

        public void WriteLine(string s) // prints string to the output
        {
            Output += s + "\n";
        }

        public void WriteLine(object o)  // prints object as the output
        {
            Output += o + "\n";
        }
    }

}
