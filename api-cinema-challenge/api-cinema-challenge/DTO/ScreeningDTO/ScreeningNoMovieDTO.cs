using api_cinema_challenge.DTO.MovieDTO;

namespace api_cinema_challenge.DTO.ScreeningDTO
{
    public class ScreeningNoMovieDTO
    {
        public int Id { get; set; }

        public int ScreenNumber { get; set; }

        public int Capacity { get; set; }

        public DateTime StartsAt { get; set; }
    }
}
