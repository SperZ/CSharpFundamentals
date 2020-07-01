using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance_Classes //inheritance the act of inheriting from a base class
{
    public class Person //parent class
    {
        private string _firstName; // setting up fields  created in class we can utilize in class
        private string _lastName;
        public string Name // property of name is set by the two private strubg
        {
            get
            {
                string fullName = $"{_firstName} {_lastName}";
                return (!string.IsNullOrEmpty(fullName)) ? fullName : "Unnamed";  // if the first or last name is unset this will return unnamed


            }
        }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public void SetFirstName(string name) 
        {
            _firstName = name; //sets the field _firstName equal to the string name 
        }

        public void SetLastName(string name) 
        {
            _lastName = name; //sets the field _lastName equal to the string 
        }

    }

    
}
