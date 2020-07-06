using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        
        // create a method that returns each char of a string
        public void LetterPrinter(string word)
        {
            foreach (char letter in word)
            {
                Console.WriteLine(letter);
            }

        }

        [TestMethod]

        //creates a method that sorts a list of strings
        public List<string> ReturnSortedList()
        {
            List<string> quesodilla = new List<string>();
            quesodilla.Sort();

            return quesodilla;

        }
        //[TestMethod]


        //create a method that sorts a list of integers smallest to biggest
        //public List<int> BiggieSmalls()
        //{
        //    List<int> listBefore = new List<int>();
        //    List<int> listAfter = listBefore.Sort();

        //    return listAfter;
        //}


        [TestMethod]

        public int StringToInt(string x)
        {
            Console.WriteLine("Input a string");
            string taco = Console.ReadLine();
            int nacho = taco.Length;

            return nacho;
        }

        [TestMethod]

        // create method that returns that takes a list of strings and returns without any vowels
        public List<string> GetByLetterNoVowels(List<string> x)
        {
            List<string> letters = new List<string>();
            foreach (char bowl in letters)
            {
                if (bowl != "a" || bowl != "e" || bowl != "i" || bowl != "o" || bowl != "u")
                {
                    letters.Add(Convert.ToString(bowl));
                }
            }

            if (letters.Count > 0)
            {
                return letters;
            }

            else
            {
                return null;
            }
        }


        [TestMethod]

        // create a method that takes a user input string and outputs the reverse
        public string OutPutReverse(string word)
        {
            string grape = Console.ReadLine();
            List<char> apple = new List<char>();
            foreach (char c in grape)
            {
                apple.Add(c);

            }
            apple.Reverse();
            return Convert.ToString(apple);

            Console.ReadKey();


        }
    }
