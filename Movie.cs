using System;
namespace TeamProject
{
    // Class Movie with three fields, _title represents the title of the movie
    // _studio represents the studio the movie was made
    // _rating represents the rating of the movie
    public class Movie
    {
        string _title;
        string _studio;
        string _rating;
    // Constructor for the class Movie
        public Movie(string title, string studio, string rating)
        {
            _title = title;
            _studio = studio;
            _rating = rating;
        }
        // Constructor of the class Movie, this takes two arguments and sets rating to PG
        public Movie (string title, string studio) 
        {
        _title = title;
        _studio = studio;
        _rating = " PG";
        }

        // A method of the class movie that returns movies rated PG only
     public static void getPG(Movie[] movies)
        {
            int movieArray = 0;
            Movie[] moviePG = new Movie[movies.Length];
            foreach (var movie in movies)
            {
                if(movie._rating == "PG")
                {
                    moviePG[movieArray] = movie;
                    movieArray++;
                }
                
            }
            Console.WriteLine("PG rated movies: ");

            for (int i = 0; i <moviePG.Length ; i++)
            {
                if(moviePG[i]!=null)
                {
                    Console.WriteLine("The movie Title is: " + moviePG[i]._title + "," +
                    " produced in Studio: " + moviePG[i]._studio + "," +  "The movie is Rated :" +
                     moviePG[i]._rating);
                }
            }
        }

    //       public static Movie[] getPG(Movie[] movie)
    //  {
    //     Movie[] pgMovie = new Movie[movie.Length];
    //     int newArrayIndex = 0;
    //     for (int i = 0; i < movie.Length; i++)
    //         {
    //             if (!movie[i]._rating.Equals("PG"))
    //             {
    //                 continue;
    //             }
    //             pgMovie[newArrayIndex] = movie[i];
    //             newArrayIndex++;
    //         }
    //         return pgMovie;
           
    // }
      
    }
}
