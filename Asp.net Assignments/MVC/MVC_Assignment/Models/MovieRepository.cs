namespace MVC_Assignment.Models
{
    public class MovieRepository
    {
        static List<Movie> movies = new List<Movie>()
        {
                new Movie(){MovieId=1,Title="Kalki",Actor="Prabhas",Language="Telugu",Director="NagAswin" },
            new Movie(){MovieId=2,Title="Bahubali",Actor="Prabhas",Language="Telugu",Director="Rajamouli"},
            new Movie(){MovieId=3,Title="Sye",Actor="Nitin",Language="Telugu",Director="Rajamouli"},

        };
        public List<Movie> GetMovies()
        {
            return movies;
        }

        public Movie GetMovieByName(string title)
        {

            return movies.SingleOrDefault(m => string.Equals(m.Title, title, StringComparison.OrdinalIgnoreCase));
        }
        public void Add(Movie movie)
        {
            movies.Add(movie);
        }

    }
}
