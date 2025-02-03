using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{
    public class ScreeningDTO : Dateing
    {
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime StartsAt { get; set; }
        public int MovieId { get; set; }
    }
    public class ScreeningDTOBig : Dateing
    {
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime StartsAt { get; set; }
        public int MovieId { get; set; }
        public MovieSmall Movie { get; set; }

    }
    public class ScreeningPost
    {
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime StartsAt { get; set; }
        public int MovieId { get; set; }
    }
}
