using _07_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent_Inheritance
{
    public class StreamingRepository : StreamingContentRepoistory
    {
        public Show GetShowByTitle(String title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower() && content.GetType() == typeof(Show)) //does the title match the title we were given and does the content match the show type we were given
                {
                    return (Show)content; // changing the content from be of type streamingContent to be of type showcasting the content to be of type show   
                }
            }
            return null;
        }

        public Movie GetMovie(string title)// will take in a title 
        {
            foreach (StreamingContent content in _contentDirectory) // content is vairable in the foreach loop the content will be assigned each item in the contentDirectory as it loops through each item of the directory
            {
                if(content.Title.ToLower() == title.ToLower() && content is Movie)// does the same thing as show but it makes it less verbous
                {     
                    return (Movie)content;
                }
            }
            return null;
        }
            
        

        public List<Show> GetAllShows()  // the type of contents that make up the list are of the class movie
        {
            List<Show> allShows = new List<Show>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is Show)
                {
                    allShows.Add((Show)content);
                }
            }
            return allShows;
        }

        //Get All Movies
        public List<Movie> GetMovies() // the type of contents that make up the list are of the class movie
        {
            List<Movie> allMovies = new List<Movie>(); // creates a new list instance of Movies named allMovies
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is Movie)
                {
                    allMovies.Add((Movie)content);
                }
            }
             if(allMovies.Count > 0)
            {
                return allMovies;

            }

            else
            {
                return null;
            }

        }

        public List<Movie> GetAllMoviesRunTime(double time)// must have parameters
        {
            List<Movie> runTimes = new List<Movie>();
            foreach(Movie content in _contentDirectory)
            {
                if(content.RunTime <= time)
                {
                    runTimes.Add(content);// add items to the list that are greater than or equal to given in time
                }
                
            }

            if(runTimes.Count > 0)
            {
                return runTimes;
            }

            else
            {
                return null;
            }
            //interfaces are basically inheritances its weird on how they get used.
        }


        public List<Movie> GetAllMoviesByRunTime(double runTime)  
        {
            List<Movie> allRunTimes = new List<Movie>(); // list of all runTimes that is of type movie
            foreach(StreamingContent content in _contentDirectory)/// _contentDirectory is inherited to the streamingRepository from the streamingContentRepositor
            {
                if (content.GetType()== typeof(Movie))  // if content type equals typeof(Movie) the program will retrieve it if it is a show it will not retrieve that item
                {
                    Movie movieContent = (Movie)content;// recasting movie content. channging the the content from the type streamingContent to the class movie 
                    if(movieContent.RunTime <= runTime) 
                    {
                        allRunTimes.Add(movieContent);
                    }
                }
            }

            if(allRunTimes.Count > 0)
            {
                return allRunTimes;
            }

            else
            {
                return null;
            }

        }


         public List<Show> GetByEpisodeNumber(int episodes) 
        {
            List<Show> episodesNumber = new List<Show>();
            foreach(Show content in _contentDirectory) // for  show object in _contentDirectory
            {
                if(content.EpisodeCount >= episodes) // the show EpisodeCount is greater than or equal to given number of episodes
                {
                    episodesNumber.Add(content); // add the show to the list episodeNumber
                }
                return episodesNumber;
            }

            if(episodesNumber.Count > 0) // if this of items is greater than 0 then return list
            {
                return episodesNumber;
            }

            else //else return null value
            {
                return null;
            }
            

         }

        public List<Show> GetEpisodeByRating(double rating)
        {
            List<Show> ratingCount = new List<Show>();
            foreach (Show content in _contentDirectory)
            {
                if (content.StarRating == rating)
                {
                    ratingCount.Add(content); //content to the list called ratingCount
                }
            }
            return ratingCount;  
        }

        public List<Movie> GetMovieByRating(MaturityRating rating)
        {
            List<Movie> maturityMovie = new List<Movie>();
            foreach(StreamingContent content in _contentDirectory)
            {
                if (content is Movie && content.MaturityRating == rating) // if streaningcontent is of contnet movie && content.Maturity rating is equal to given the parameter
                {
                    maturityMovie.Add((Movie)content);// casts the object content of the class streamingContent to become a movie content

                }
                
                //the only way we get to properties of an object is through our dot operator .
                
                //if(content is movie) {}
                //if (content.GetType() == typeof(Movie)){}
                //if

                //Movie newMovie = (Movie)content; // casting a streamingContent type to a movie type
                //if(newMovie.MaturityRating == x)
                //{
                //    maturityMovie.Add(newMovie);
                //}
            }

            if (maturityMovie.Count > 0)
            {
                return maturityMovie;
            }

            else
            {
                return null; // will return nothing if their is no movies that matches the users desired maturityRating
            }
            
        }

        public List<Movie> GetMovieByRating(double rating)
        {
            List<Movie> ratingCount = new List<Movie>();
            foreach(Movie content in _contentDirectory)
            {
                if(content.StarRating == rating)
                {
                    ratingCount.Add(content);
                }
            }
            if(ratingCount.Count > 0)
            {
                return ratingCount;
            }


            else
            {
                return null;
            }
        }

        public List<Show> GetShowByAverage(double runTime)
        {
            List<Show> shows = new List<Show>();
            {
                foreach(Show content in _contentDirectory) 
                {
                    if (content.AverageRunTime == runTime)
                    {
                        shows.Add(content);
                    }
                }

                if(shows.Count > 0)
                {
                    return shows;
                }

                else
                {
                    return null;
                }
            }
        }
        // if you dont know whether your streamingContent is a movie or a 
    }
}
