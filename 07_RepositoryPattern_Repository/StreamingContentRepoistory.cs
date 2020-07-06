using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{   // a repository is a place, building, or receptacle where things may be stored in this case we are storing methods that act upon our class streaming content within our repository 
    //Here we are creating class object that is acts as our repository of all of our properties of our streaming content by planting them in a list
    
    public class StreamingContentRepoistory // if this is missing a access modifier it is treated as internal and error  may be thrown
    {
        //not using database so simulating a database  // once we create the list we dont want to override it so we do readonly
        protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();// this is our fake database //tranplants all the properties of the streaming content into a list which we will use as our _contentDirectory
                                                                                                   //the above is a field and naming convention says we start with an underscore _contentDirectory
                                                                                                   //CRUD

        //Create you have to create the thing before you do anything with it
        public bool AddContentToDirectory(StreamingContent content)// when called it will be passed an instance of streamingcontent named content // this method will add content to the directory
        {
            int startingCount = _contentDirectory.Count;// gets the number of elements in the list
            _contentDirectory.Add(content);//must be accessed through the method we are building // adds the contents of StreamingContent content to our content directory _contentDirectory
            bool wasadded = (_contentDirectory.Count > startingCount) ? true : false; // checks to see if items have been added to our content directory we can tell this because if the _contentdirectory.count is greatern than the starting count then we know that the items have been added thus the bool wasadded will return true
            return wasadded;
        }// one reason you might do this is to act a built in test so if it didnt it will report error users, catch if something goes wrong

        public StreamingContent AddContentToDirectorys(StreamingContent content)
        {
            _contentDirectory.Add(content);
            return content;
        }

        //Read
        public List<StreamingContent> GetContents()//this gets the list of contents of Streaming Content
        {
            return _contentDirectory;
        }

        public StreamingContent GetContentByTitle(string title) // this returnings a streaming content object type that fits 
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }
            return null; // returns null if content.Title is not in _contentDirectory
        }

        public List<StreamingContent> GetContentList(string titles)
        {
            List<StreamingContent> title = new List<StreamingContent>();
            foreach(StreamingContent item in _contentDirectory)
            {
                if(item.Title.ToLower()  == titles.ToLower())
                {
                    title.Add(item);
                }
            }
            if(title.Count > 0)
            {
                return title;
            }

            else
            {
                return null;
            }
        }

        //Build Method
        //Get by other parameters
        //Get by Rating
        //Get by FamilyFriendly
        //Etc.



        public List<StreamingContent> GetbyMaturity(MaturityRating x)// streamingContent return type with the return type being MaturityRating named x, which would be user input
        {
            List<StreamingContent> rating = new List<StreamingContent>(); //creates new instance of list with return type of StreamingContent named ratingList
            foreach (StreamingContent ageItems in _contentDirectory) // foreach item in the _contentDirectory with the type being StreamingContent and the name being rating
            {
                if (ageItems.MaturityRating == x) //if the MaturityRating of the ageRating with type streamingContent is equal to
                {
                    rating.Add(ageItems);//add the variable ageRating to the ratingList list
                }
            }
            return rating; //if it is equal just return the ratingList
        }

        public StreamingContent GetDescription(string description)
        {
            foreach (StreamingContent describe in _contentDirectory)
            {
                if (describe.Description.ToLower() == description.ToLower())
                {
                    return describe;
                }
            }
            return null;
        }

        public StreamingContent GetIsFamilyFriendly(bool isFamilyFriendly)
        {
            foreach (StreamingContent friendly in _contentDirectory)
            {
                if (friendly.IsFamilyFriendly == isFamilyFriendly) // if the property of class StreamingContent  is == to the parameter isFamilyFriendly of the StreamingContent list instance we created known, it will return friendly
                {
                    return friendly;
                }
            }
            return null; //
        }

        public List<StreamingContent> GetByIsFamilyFriendl(bool isFamilyFriendly)
        {
            List<StreamingContent> sortedList = new List<StreamingContent>(); // method is interchangable by with any other non-unique identifier
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.IsFamilyFriendly == isFamilyFriendly)
                {
                    sortedList.Add(content);
                }
            }
            return sortedList;
        }


        public List<StreamingContent> GetByStaringRating(double rating) //new instance of reference type List with contents of streaming contentList<StreamingContent> GetStarRating(double rating)
        {
            List<StreamingContent> newRating = new List<StreamingContent>();//new instance of reference type List with contents of streaming content
            foreach (StreamingContent content in _contentDirectory)//StreamingContent is treated as variable type in this with the name of 
            {
                if (content.StarRating >= rating)//checking to see if StreamingContent(class/object) content(name) StarRating(property) is equal to the parameter of rating within the _contentDirectory
                {
                    newRating.Add(content);
                }
            }
            return newRating;
        }

        public List<StreamingContent> GetGenre(GenreType genre)
        {
            List<StreamingContent> newGenre = new List<StreamingContent>();
            foreach (StreamingContent movieType in _contentDirectory)
            {
                if (movieType.TypeOfGenre == genre)
                {
                        newGenre.Add(movieType);
                }
            }

            return newGenre;//must fall outside foreach statement
        }


        //Update
        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle); //creates a new instance of StreamingContent gets the contents of original title they would like to update and merges it with new content
            if (oldContent != null) // if the original title is there then  it procces to updating the the oldcontent of the original title to the new content that the user inputs
            {
                oldContent.Title = newContent.Title; //  if you didnt want the user to be able to change a given property you would leave it out of this list.
                oldContent.Description = newContent.Description;//
                oldContent.StarRating = newContent.StarRating;//
                oldContent.MaturityRating = newContent.MaturityRating;//
                oldContent.TypeOfGenre = newContent.TypeOfGenre; //
                return true;
            }

            else
            {
                return false;
            }
        }

        //Delete
        public bool DeleteExistingContent(StreamingContent existingContent)// creates new instances called existingContent
        {
            bool deleteResult = _contentDirectory.Remove(existingContent); // bool will return true if the existingContent is successfully deleted    
            return deleteResult;
        }


    }
}

