﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //While Loop checks condition while condition is true
            int total = 1;
            while (total != 10)
            {
                Console.WriteLine(total);
                total = total + 1;
            }

            total = 0;
            while (true)
            {
                if(total == 10)
                {
                    Console.WriteLine("You did it!");
                    break;
                }
                total++;
            }

            Random rand = new Random();
            int someCount;
            bool keepLooping = true;

            while (keepLooping)
                {
                someCount = rand.Next(0, 20);
                if (someCount == 6 || someCount == 10)
                {
                    continue;
                }
                Console.WriteLine(someCount);
                if (someCount == 15)
                {
                    keepLooping = false;
                }
            }

            //For loop for(starting point; conditional; what is done at the end of each loop;)
            int studentCount = 5;
            for(int i = 0; i < studentCount; i++)
            {
                Console.WriteLine(i);
            }

            string[] students = { "Nick", "Adam", "AJ", "Austin", "Severa", "Tim" };
            for(int i=0; i < students.Length; i++)
            {
                Console.WriteLine($"Hello there! { students[i]}!");
            }

            //Foreach loop(type of collection;
            foreach (string student in students)
            {
                Console.WriteLine(student + " is in the class today.");
            }

            string myName = "Zachary Russell Sperka";
            foreach (char letter in myName)
            {
                if(letter !=' ')
                {
                    Console.WriteLine(letter);
                }

            }

            //do while different from while loop it execute at least once, it runs once then checks conditional
            int iterator = 0;

            do
            {
                Console.WriteLine("Hello!");
                iterator++;
            }
            while (iterator < 5);

            do
            {
                Console.WriteLine("My do while condition is false!");
            } while (false);

            while (false)
            {
                Console.WriteLine("This is a test");
            }
            Console.ReadLine();
        }
    }
}