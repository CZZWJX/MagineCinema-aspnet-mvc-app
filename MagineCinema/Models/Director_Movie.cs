namespace MagineCinema.Models
{
    public class Director_Movie
    {
        public int directorId { get; set; }
        public Director director { get; set; }
        public int movieId { get; set; }
        public Movie movie { get; set; }
    }
}
