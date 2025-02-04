using api_cinema_challenge.DTO.ScreeningDTO;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO.MovieDTO
{
    public class MoviesDTO
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Rating { get; set; }

        public string Description { get; set; }

        public int RuntimeMins { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public virtual ICollection<ScreeningNoMovieDTO> Screenings { get; set; } = new List<ScreeningNoMovieDTO>();
    }
}
