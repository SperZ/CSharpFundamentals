using System;
using System.Collections.Generic;
using CarInsurance_RepositoryChallenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarInsurance_Tests
{
    [TestClass]
    public class UnitTest1
    {
        private readonly KomodoCustomer_Repository _customerRepository = new KomodoCustomer_Repository();
        [TestMethod]
        public void SetCustomerName_TestMethod1()
        {
            KomodoCustomers newCustomer = new KomodoCustomers();
            newCustomer.LastName = "Erics";

            string expected = "Erics";
            string actual = newCustomer.LastName;
            Assert.AreEqual(expected, newCustomer.LastName);

        }

        [TestMethod]
        public void SetCustomersAge_ShouldSetCustomersAge()
        {
            KomodoCustomers newCustomer = new KomodoCustomers();
            newCustomer.Age = 4;

            int expected = 4;
            int actual = newCustomer.Age;

            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        
        public void SetCustomerYears_ShouldSetCustomersYears()
        {
            KomodoCustomers newCustomer = new KomodoCustomers();
            newCustomer.YearsAsCustomer = 6;

            int expected = 6;
            int actual = newCustomer.YearsAsCustomer;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void SetCustomersEnrollmentDate_ShouldSetCorrectDate()
        {
            KomodoCustomers newCustomer = new KomodoCustomers();
            newCustomer.EnrollmentDate = new DateTime(1999, 3, 10);

            DateTime expected = new DateTime(1999, 3, 10);
            DateTime actual = newCustomer.EnrollmentDate;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CustomerListTest_ShouldReturnAllAdds()
        {
            List<KomodoCustomers> customerList = new List<KomodoCustomers>();
            KomodoCustomers tony = new KomodoCustomers();
            KomodoCustomers blake = new KomodoCustomers();
            KomodoCustomers george = new KomodoCustomers();

            customerList.Add(tony);
            customerList.Add(blake);
            customerList.Add(george);

            Assert.AreEqual(3, customerList.Count);

            customerList.Remove(tony);

            Assert.AreEqual(2, customerList.Count);


        }
    }
}
