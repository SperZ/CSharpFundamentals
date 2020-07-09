using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Classes_AfterHours
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsMarried { get; set; }

        public Person () { }// only time we need to type this out is when we have an overloaded constructor

        public Person(string name, int age, bool isMarried)
        {
            Name = name;
            Age = age;
            IsMarried = isMarried;
        }
        //repository is a class that holds the methods that equals the functionality for the person class
    }
}
