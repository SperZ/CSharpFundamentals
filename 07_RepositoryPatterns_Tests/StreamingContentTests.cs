using System;
using System.IO;
using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_RepositoryPatterns_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void SetTitle_ShouldSetCorrectString()// RENAME TO WHAT WE ARE TESTING // in this we are testing the set title functionality
        {
            // cntrl . when hovered over StreamingContent then add reference to your other project file

            StreamingContent content = new StreamingContent();  // creates new instance of the object StreamingContent named content 
            content.Title = "Back to the Future";

            Assert.AreEqual("Back to the Future", content.Title);

            string expected = "Back to the Future"; // what variable is expected
            string actual = content.Title; // what variable is the actual variable

            
            Assert.AreEqual(expected, actual);// tests whether the expected value is equal to the actual value  // if they are not equal the test will fail
        }

        [TestMethod]
        public void SetRating_ShouldTestStarRating() 
        {
            StreamingContent content = new StreamingContent();
     
            content.StarRating = 4.8;

            Assert.AreEqual(4.8, content.StarRating);

            double expected = 4.8d;
            double actual = content.StarRating;

            Assert.AreEqual(expected, actual);
        }

       
        [TestMethod]
        public void GenreType_TestingGenreType()// definitely a good reference for testing enums
        {
            StreamingContent content = new StreamingContent();
            content.TypeOfGenre = GenreType.SciFi; // you have to select the property associated with the enum and then set it equal to the Enum.Value in this case the enum is GenreType with the property associated with the class being TypeOfGenre then you must set it equal to the Enum and a given value associated with the enum in this case GenreType.SciFi

            Assert.AreEqual(GenreType.SciFi, content.TypeOfGenre);

        }
        
        [DataTestMethod]
        [DataRow(GenreType.Thriller)]
        [DataRow(GenreType.Action)]
        [DataRow(GenreType.SciFi)]
        public void SetGenre_ShouldSetCorrectGenre(GenreType genre)// runs this test method for however many datarows we have
        {
            //TRIPLE A paradigm
            //Arrange // set the stage
            StreamingContent content= new StreamingContent();
            //Act // calll functionality
            content.TypeOfGenre = genre;
            //Assert // checks the value against expected
            Assert.AreEqual(genre, content.TypeOfGenre);
        }



        [TestMethod]
        public void SetGenreType_ShouldTestGenreType()
        {
            StreamingContent content2 = new StreamingContent("Homeward Bound", "Pets find their way back home", MaturityRating.G , 3.5, GenreType.Adventure);

            Assert.AreEqual("Homeward Bound", content2.Title);

        }
    }
}
