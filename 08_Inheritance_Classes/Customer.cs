using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance_Classes
{
   public class Customer : Person    //class we are building : class we are inheriting from        child class : parent class
    {
        public  bool IsPremium { get; set; }
        public bool SubscribedToEmails { get; set; }
        public int MyProperty { get; set; }
    }
}
