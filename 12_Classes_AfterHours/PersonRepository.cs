using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Classes_AfterHours
{
    public class PersonRepository
    {
        List<Person> _listOfPeople = new List<Person>(); // this is an empty list name listOfPeople which can hold person objects // it starts as holidng no objects
        // every other method within the repository class will be able to see the new listOfPeople

        public void AddPeople(Person s) // s is a place holer for a personobject
        {
            _listOfPeople.Add(s); // list is engrained in this method so there within methods we need to 
        }

        public void DeletePerson(Person t) // we are removing the parameter that the user passed in
        {
            _listOfPeople.Remove(t);
        }
        
        public List<Person> ReturnList()
        {
            return _listOfPeople;
        }
    }
}
