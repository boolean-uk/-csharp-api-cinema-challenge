using api_cinema_challenge.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.DTO
{
    public class ScreenDTO
    {
        public int screenId { get; set; }
        public int screenNumber { get; set; }
        public int capacity { get; set; }
        public DateTime startsAt { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public virtual List<string> tickets { get; set; }
        public virtual List<string> movies { get; set; }

        public ScreenDTO(Screen screen)
        {
            screenId = screen.screenId;
            screenNumber = screen.screenNumber;
            capacity = screen.capacity;
            startsAt = screen.startsAt;
            createdAt = screen.createdAt;
            updatedAt = screen.updatedAt;
            tickets = new List<string>();
            movies = new List<string>();
            //convert tickets and movies to strings 
            screen.tickets.ForEach(x => tickets.Add($" ticket id : {x.ticketId}, customer: {x.customer.Name}"));
            screen.moviesOnScreen.ForEach(x => movies.Add($" movie id {x.movieId}, movie title {x.movie.Title}"));
            
        }
    }
}
