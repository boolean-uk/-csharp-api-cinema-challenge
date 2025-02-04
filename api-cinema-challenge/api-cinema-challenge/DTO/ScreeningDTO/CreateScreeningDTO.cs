namespace api_cinema_challenge.DTO.ScreeningDTO
{
    public class CreateScreeningDTO
    {

        public int ScreenNumber { get; set; }

        public int Capacity { get; set; }

        public DateTime StartsAt { get; set; }

        public int MovieId { get; set; }
    }
}
