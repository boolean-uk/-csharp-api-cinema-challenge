namespace api_cinema_challenge.Models
{
    public class Movie : Dateing
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }
        public IEnumerable<Screening> Screenings { get; set; }
    }
}
