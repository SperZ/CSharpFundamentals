using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance_Classes.Animals
{

    public enum DietType { Herbivore, Carnivore, Omnivore, Insectivore, Pescivore }
    public class Animals
    {
        // polymorphism allows use to a method 
        public int NumberOFLegs { get; set; }
        public bool IsMammal { get; set; }

        public bool HasFur { get; set; }
        public bool Endangered { get; set; }

        public DietType TypeOfDiet { get; set; }

        public virtual void Move() //virtual lets you have the ability to have the classes redefined inside of a method
        {
            Console.WriteLine($"This {GetType().Name} moves.");
        }

    }
}
