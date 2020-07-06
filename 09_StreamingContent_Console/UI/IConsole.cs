using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContent_Console.UI
{
    public interface IConsole // building interface to inherit to mockconsole and realconsole // Intefaces are like contracts every other thing that implements this must have these same blue print items
    {
        void WriteLine(string s);  // this takes in a string
        void WriteLine(object o);// this takes in a object
        void Clear();// this clears the console
        string ReadLine();// this takes in users input
        ConsoleKeyInfo ReadKey();// the reads a key went entered

    }
}
