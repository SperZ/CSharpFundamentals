using _12_Classes_AfterHours;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Console
{
    public class ProgramUI
    {
        public void Run()
        {
            Person person1 = new Person();
            person1.Name = "Jeff";  // jeff is a real value name that is being stored within the person1 object
            person1.Age = 48; // 48 is now inside the age property of person 1
            person1.IsMarried = true;

            Person mike = new Person("mike", 39, false); // this is the real object that will passed to through the repository this is using the overloaded constructor // the real values are what is written within the paranthese they are the real value parameters of the object mike

            PersonRepository repo = new PersonRepository(); // this is newing up an new instance of the personrepository object
            repo.AddPeople(person1);
            repo.AddPeople(mike);


            List<Person> localList = repo.ReturnList(); // in order for the value to be saved as a list you must create a new instance of List<Person> that copies all the data 
            
            Console.WriteLine(person1.Name);
            int number = localList.Count();
            Console.WriteLine(number);
        }
        
        
    }
}
