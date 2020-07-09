using System;
using System.Collections.Generic;
using _12_Classes_AfterHours;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _12_TestPerson
{
    [TestClass]
    public class UnitTest1
    {
        // this allows each mehtod to see what we put in their
        //sets all globals to be accessible by all test methods
        PersonRepository _repo = new PersonRepository();
        [TestMethod]
        public void TestMethod1__AddPersonMethod() // all test methods are independent of each other // they test  /this is a method to test a method
        {
            //Arrange
            Person mike = new Person();

            //Act // in the act we are using the methods
            _repo.AddPeople(mike);
            List<Person> localList =_repo.ReturnList();
           
            //Assert
            int expected = 1; // number items expected the list is expected to contain
            int actual = localList.Count; // number of list items that it actually contains
            Assert.AreEqual(expected, actual);
        }
    }
}
