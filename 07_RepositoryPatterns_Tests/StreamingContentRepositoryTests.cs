using System;
using System.Collections.Generic;
using System.IO;
using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_RepositoryPatterns_Tests
{
    [TestClass]
    public class StreamingContentRepositoryTests
    {
        //Create
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            //Arrange
            StreamingContent content= new StreamingContent();//creating new instance of the streamingContent named content

            //create instance of our repository so we can test that we can calll that instance
            StreamingContentRepoistory repo = new StreamingContentRepoistory(); // creates new streaming content repoistory named repo

            //Act
            bool addResult = repo.AddContentToDirectory(content);

            //Assert
            Assert.IsTrue(addResult);
        }

        [TestMethod]
        public void GetContents_ShouldReturnContents()
        {
            //Arrange
            StreamingContent content = new StreamingContent(); // new instance  
            StreamingContentRepoistory repo = new StreamingContentRepoistory(); // new instance of repository
            repo.AddContentToDirectory(content);

            //ACT
            List<StreamingContent> contents = repo.GetContents();

            bool directoryHasContent = contents.Contains(content);
            //Assert

            Assert.IsTrue(directoryHasContent);
        }

        private StreamingContentRepoistory _repo;// this sets the repository up as a field 
        private StreamingContent _content;// this sets the content as a field created in a class  and as such we can call it in any test method below

        [TestInitialize]
        public void Arrange()
        {
            _repo = new StreamingContentRepoistory();// this field _repo has all the methods available to us, which we set up in the repository
            _content = new StreamingContent("Mr. Right", "Hitman falls in love", MaturityRating.R, 55.5, GenreType.Action); // the field _content is given all the same values of the the new instance of streaming content so the field _content(string title="Mr. Right", string description="Hitman Falls in love",MaturityRating =MaturityRating.R, double rating = 55.5, GenreType genre = GenreType.Action)
            _repo.AddContentToDirectory(_content); //this adds sll of our streamingContent values to our repository // the content _content are now within callable in our repository
        }

        //Read
        [TestMethod]
        public void GetByTitle_ShouldReturnCorrectContent()
        {
            //Arrange      done above
            //Act (what does the method i am calling return)
            StreamingContent searchResults = _repo.GetContentByTitle("Mr. Right");

            //Assert!
            Assert.AreEqual(_content, searchResults);
        }
        //DRY code (do not repeat yourself)
        //WET code (we enjoy typing)

        [TestMethod]
        public void GetByMaturityRating_ShouldReturnMaturityRating()
        {
            //Arrange
            //Act
           List <StreamingContent> age = _repo.GetbyMaturity(MaturityRating.R);

            //Assert
            Assert.AreEqual(_content, age);

        }

        [TestMethod]
        public void GetByDescription_ShouldReturnDescription()
        {
            //Arrange
            //Act
            StreamingContent description = _repo.GetDescription("Hitman falls in love");

            Assert.AreEqual(_content, description);

        }

        //[TestMethod]
        //public void GetFamilyFriendly_ShouldReturnFamilyFriendly()
        //{
        //    //Arrange
        //    //Act
        //    List<StreamingContent> familyFriendly = _repo.GetIsFamilyFriendly();

        //    //Assert
        //    Assert.AreEqual(_content, familyFriendly);
        //}

        [TestMethod]// must be above the method for test to work
        public void GetByStarRating_ShouldReturnStarRating()
        {
            //Arrange
            //Act
            List<StreamingContent> rating = _repo.GetByStaringRating(55.5); // the type must be equal to the return type of the method // the parameters within the ()must be of the same type of parameters within the method if the method takes in a double then what is enter in parantheses must be a double

            //Assert
            Assert.AreEqual(_content, rating);
        }

      
        [TestMethod]
        public void GetGenre_ShouldReturnGenre()// What the best we to read and return an enum?
        {
            //Arrange
            //Act
            List<StreamingContent> type = _repo.GetGenre(GenreType.Action);// when you are wanting to return what is read we must start with the instance type in the context the instance type is StreamingContent

            Assert.AreEqual(_content, type );
        }

        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        { 
        
            //Arrange 
            StreamingContent newContent  =new StreamingContent("Mr. Right", "Hitman falls in love, and gains a new partner in crime", MaturityRating.R, 100, GenreType.Romance);

            //act
            bool updatedResult = _repo.UpdateExistingContent("Mr. Right", newContent);

            //Assert
            Assert.IsTrue(updatedResult);
            Assert.AreEqual(GenreType.Romance, _content.TypeOfGenre);
        }

        [TestMethod]
        public void DeleteExistingContent_ShouldReturnTrue()
        {
            //Arrange
            StreamingContent content1 = _repo.GetContentByTitle("Mr. Right");

            //AcT
            bool removeResult = _repo.DeleteExistingContent(content1);

            //Assert
            Assert.IsTrue(removeResult);

        }

    }
}
