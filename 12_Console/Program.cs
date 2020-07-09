using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Console
{
    class Program
    {
        static void Main(string[] args) // this method will get hits first when the start buttton/run test button is pushed    /// this is where our program starts
        {
            ProgramUI ui = new ProgramUI(); // need to new up instance of ProgramUI named ui to have access to the the run method // ui is an new instance/object ProgramUI
            ui.Run();
        }
    }
}
