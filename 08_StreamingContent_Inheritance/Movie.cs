using _07_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent_Inheritance
{
    public class Movie : StreamingContent
    {
        public double RunTime{ get; set; }

        public Movie()
        {

        }
        public Movie(string title, string description, MaturityRating maturityRating, double rating, GenreType genre, double runTime)
            :base(title, description, maturityRating, rating, genre)
        {
            RunTime = runTime;
        }
    }
}
