using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{
    public class MovieDTO : Dateing
    {
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }
        public IEnumerable<ScreeningDTO> Screenings { get; set; }

    }
    public class MovieSmall : Dateing
    {
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }
    }
    public class MoviePost
    {
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }
    }
}
