namespace MVC_Assignment.Models
{
    public class MovieRepository
    {
        static List<Movie> movies = new List<Movie>()
        {
            new Movie(){MovieId=1,Title="Kalki",Actor="prabhas",Language="Telugu",Director="NagAswin" },
             new Movie(){MovieId=1,Title="Kalki",Actor="prabhas",Language="Telugu",Director="NagAswin"},
              new Movie(){MovieId=1,Title="Kalki",Actor="prabhas",Language="Telugu",Director="NagAswin"},

        };
        public List<Movie> GetMovies()
        {
            return movies;
        }

        public Movie GetMovieByName(string title)
        {

            return movies.Single(p => p.Title == title);
        }
        public void Add(Movie movie)
        {
            movies.Add(movie);
        }

    }
}
