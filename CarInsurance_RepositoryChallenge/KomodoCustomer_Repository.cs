using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance_RepositoryChallenge
{
    public class KomodoCustomer_Repository
    {
       private readonly List<KomodoCustomers> _listOfCustomers = new List<KomodoCustomers>();
        
        //Create  
        public KomodoCustomers AddCustmoerToList(KomodoCustomers s)
        {
            _listOfCustomers.Add(s);
            return s;
        }

        //Read
        public List<KomodoCustomers> GetAllCutomers()
        {
            return _listOfCustomers;
        }

        public KomodoCustomers GetCustomerById(int id)
        {
            foreach(KomodoCustomers s in _listOfCustomers)
            {
                if(s.Id == id)
                {
                    return s;
                }
            }
            return null;
        }

        public List<KomodoCustomers> GetCustomersByYears(int y)
        {
            List<KomodoCustomers> years = new List<KomodoCustomers>();
            foreach(KomodoCustomers b in _listOfCustomers)
            {
                if(b.YearsAsCustomer == y)
                {
                    years.Add(b);
                    return years;
                }
            }
            return null;
        }


        //Upate
        public bool UpdateCustomerInformation(int r, KomodoCustomers newCustomer)
        {
            KomodoCustomers oldCustomer = GetCustomerById(r);

            if(oldCustomer != null)
            {
                oldCustomer.Age = newCustomer.Age;
                oldCustomer.LastName = newCustomer.LastName;
                oldCustomer.Id = newCustomer.Id;
                oldCustomer.YearsAsCustomer = newCustomer.YearsAsCustomer;
                return true;
            }
            else
            {
                return false;
            }

        }

        //Delete
        public bool DeleteExistingCustomer(KomodoCustomers s)
        {
            bool deleteResult = _listOfCustomers.Remove(s);
            return deleteResult;

        }

        public void ThankYouLetter()
  
        {

            foreach(KomodoCustomers s in _listOfCustomers)

            {
                if(s.YearsAsCustomer >= 1 && s.YearsAsCustomer <= 5)
                {
                    Console.WriteLine("Send them a thank you note");
                }

                else if(s.YearsAsCustomer > 5)
                {
                    Console.WriteLine("Thank you for being a Gold member");
                }

                
            }
        }
    }
}
