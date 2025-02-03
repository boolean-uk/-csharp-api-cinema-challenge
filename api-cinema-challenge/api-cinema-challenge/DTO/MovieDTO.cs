using api_cinema_challenge.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.DTO
{
    public class MovieDTO
    {
        public int movieId { get; set; }
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public string RuntimeMins { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public virtual List<string> screens { get; set; } = new List<string>();

        public MovieDTO(Movie movie) 
        {
            movieId = movie.movieId;
            Title = movie.Title;
            Rating = movie.Rating;  
            Description = movie.Description;
            RuntimeMins = movie.RuntimeMins;
            CreatedAt = movie.CreatedAt.ToString();
            UpdatedAt = movie.UpdatedAt.ToString();
            movie.screens.ForEach(x => screens.Add(x.screenNumber.ToString()));
        }
    }
}
