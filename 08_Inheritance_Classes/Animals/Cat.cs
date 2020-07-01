using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance_Classes.Animals
{
    public class Cat : Animals
    {
        public double clawlenght { get; set; }

        public virtual void MakeSounds() // virtual methods can be redefined so when we run virtual method it will allow us to ovverride it in a inheritted class
        {
            Console.WriteLine("Mewo");
        }
        //overrides method built in animals

        public override void Move()
        {
            Console.WriteLine($"The {GetType().Name} moves quickly."); // instead of having the Move() method assiocated with the base class animal it has been change to perform the method defined hear because it is override
        }
    }

    public class Liger : Cat
    {
        public override void MakeSounds()
        {
            Console.WriteLine("Roar"); // overrides the previous make sounds methods
        }

        public override void Move()
        {
            Console.WriteLine($"the {GetType().Name} stalks its prey."); // getType.Name gets type of class instance and the .name then takes the name of the class and prints it out in the line. so this would read The Liger stalks its prey.
        }
    }
    

    public class TabbyCat : Cat
    {
        public override void MakeSounds()
        {
            base.MakeSounds();// Looks at the base method of the parent class
            Console.WriteLine("Purr");
        }
       
    }
}
