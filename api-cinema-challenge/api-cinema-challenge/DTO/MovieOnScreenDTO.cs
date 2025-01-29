using api_cinema_challenge.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.DTO
{
    public class MovieOnScreenDTO
    {

        public virtual string movieTitle { get; set; }
        public virtual string screenNumber { get; set; }
        public int movieId { get; set; }
        public int screenId { get; set; }

        public MovieOnScreenDTO(MovieOnScreen movieOnScreen) 
        {
            movieTitle = movieOnScreen.movie.Title;
            screenNumber = movieOnScreen.screen.screenNumber.ToString();
            movieId = movieOnScreen.movieId;
            screenId = movieOnScreen.screenId;
        }
    }
}
