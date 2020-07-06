using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContent_Console.UI
{
    public class RealConsole : IConsole  // realConsole is implementing the blueprint that was set up in IConsole
    {
        public void Clear()
        {
            Console.Clear();// this clears the console of anything that was on the screen previously
        }

        public ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey(); // pause the progran and waits for sone key outcome
        }

        public string ReadLine()
        {
            return Console.ReadLine(); // this returns what the user has inputted into the console
        }

        public void WriteLine(string s)
        {
            Console.WriteLine(s); //this writes to the console a given string that is passed in
        }

        public void WriteLine(object o)
        {
            Console.WriteLine(o); // this will write to the console a given object that is put in
        }
    }
}
