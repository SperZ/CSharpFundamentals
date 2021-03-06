﻿using _09_StreamingContent_Console.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContent_Console
{
    public class Program //entry point to application this will direct us around the program we want to build
    {
        static void Main(string[] args)
        {
            IConsole console = new RealConsole(); // IConsole console = the specific class console this tells it to use the real console
            ProgramUI ui = new ProgramUI(console);
            ui.Run();// only have access to Run because RunMenu is not accessible
        }
    }
}
