using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_VariablesAndValueTypes
{ 
 
    class Program
    {
        enum PastryType { Cake, Cupcake, Croissant, Donut, Cookie, Scone, Danish}
        static void Main(string[] args)
        {
            bool isDeclared;// a boolean that is declared
            isDeclared = true;

            bool isDeclaredAndInitialized = false;// a boolean that is declared then initialized to the value of false
            isDeclaredAndInitialized = true;

            char characters = 'a';
            char symbol = '&';
            char number = '5';
            char space = ' ';
            char specialCharacter = '\n'; //breaks the two character word, because not printed to screen, but telling the program to do something

            // Whole Numbers
            byte byteExample = 255; //highest byte can go
            sbyte sByteExample = -128;
            short shortExample = 32767; // 16 bit integer
            Int16 anotherShortExample = 32000; // 16 bit integer
            int intMin = -2147483648; //32 bit integer
            Int32 intMax = 2147483647; // 32 bit integer
            long longExample = 9223372036854775807; //64 bit integer maximum
            Int64 longMin = -9223372036854775808; //64 bit integer mininum

            int a = 7;
            int b = -7000;

            byte age = 104;

            //Decimals
            float floatExample = 1.045231f;
            double doubleExample = 1.789053278907036d;//d differeniates it from decimal
            decimal decimalExample = 1.2578907289045789789789789787897m;// m is suffix for decimal
            Console.WriteLine(1.2578907289045789789789789787897f);
            Console.WriteLine(1.2578907289045789789789789787897d);
            Console.WriteLine(1.2578907289045789789789789787897m);


            Console.ReadKey();

            //Enum

            PastryType myPastry = PastryType.Croissant;
            PastryType anotherOne = PastryType.Donut;

            //Structs
            Int32 num = 42;
            DateTime today = DateTime.Today;
            DateTime birthday = new DateTime(1805, 11, 24);
            DateTime test = new DateTime();

        }
    }
}
