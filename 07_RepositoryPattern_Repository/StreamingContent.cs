using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository// packages of code that work together that are assembled together in the same project
{   // this StreamingContent Class is the Object or the blueprint for what is going to be used in our repository StreamingContentRepository
    public enum GenreType //enums always are established outside of the class
    {
        Horror = 1, // sets vakue to start at 1 and not 0  //When saved in database it will be saved by number similiar to and index value
        Romance,
        SpaghettiWestern,
        Anitmated,
        SciFi,
        Drama,
        Action,
        Comedy,
        Anime,
        Documentary,
        Thriller,
        SportsMovie,
        Adventure

    }

    public enum MaturityRating  // isFamilyFriendly will be set by what maturity rating is
    {
        G,
        PG,
        PG_13,
        R,
        NC_17,
        TV_MA
    }
    public class StreamingContent // StreamingContent is our POCO Plain Old C# Object
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public MaturityRating MaturityRating { get; set; }
        public double StarRating { get; set; }
        public bool IsFamilyFriendly // now determined by the maturity rating // is readonly property because we take away the ability to be set
        { get 
            { 
            switch (MaturityRating)
                {
                    case MaturityRating.G:
                    case MaturityRating.PG:
                        return true;
                    case MaturityRating.PG_13:
                    case MaturityRating.R:
                    case MaturityRating.NC_17:
                    case MaturityRating.TV_MA:
                    default:
                        return false;
                }
                //Another way to do this
                //if((int)MaturityRating > 1)
                //{
                //    return false;
                //}
                //elsethank
                //{
                //    return true;
                //}// do not need 
            }
        
        }
        public GenreType TypeOfGenre { get; set; }

        public StreamingContent() { }// kind of like a default constructor which allows for us to use either an empty constructor or overloaded constructor

        public StreamingContent(string title, string description, MaturityRating maturityRating, double rating, GenreType genre)// ctor tab tab will build empty constructor
        {
            Title = title;
            Description = description;
            MaturityRating = maturityRating;
            StarRating = rating;
            TypeOfGenre = genre;
        }
       
    }
}
