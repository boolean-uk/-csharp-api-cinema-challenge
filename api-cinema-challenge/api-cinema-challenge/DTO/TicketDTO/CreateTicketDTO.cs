using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO.TicketDTO
{
    public class CreateTicketDTO
    {
        public int NumSeats { get; set; }

        public int CustomerId { get; set; }

        public int ScreeningId { get; set; }
    }
}
