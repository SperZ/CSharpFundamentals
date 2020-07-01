using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance_Classes.Animals
{
    public class Sloth : Animals
    {
        public bool IsSlow
        {
            get { return true; }
        }

        public override void Move()
        {
            Console.WriteLine("The sloth moves slowly");
        }
    }

    public class Megatherium : Sloth
    {
        public override void Move()
        {
            Console.WriteLine("Megatherium uses Move! its not super effective....");
 
        }
    }
}
