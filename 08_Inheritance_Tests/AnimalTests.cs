using System;
using _08_Inheritance_Classes.Animals;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_Inheritance_Tests
{
    [TestClass]
    public class AnimalTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Cat firstCat =new Cat();
            firstCat.Move();
            firstCat.MakeSounds();

            Liger oneLiger = new Liger();
            oneLiger.MakeSounds();
            oneLiger.Move();

            Animals oneAnimal = new Animals(); //reason you may make a class abstract is to make it so you cannot create instances from that object it.
            oneAnimal.HasFur = false;
         }
    }
}
