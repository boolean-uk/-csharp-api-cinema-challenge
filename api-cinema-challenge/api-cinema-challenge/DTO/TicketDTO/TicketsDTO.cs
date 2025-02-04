using api_cinema_challenge.DTO.CustomerDTO;
using api_cinema_challenge.DTO.ScreeningDTO;
using api_cinema_challenge.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.DTO.TicketDTO
{
    public class TicketsDTO
    {
        public int Id { get; set; }
  
        public int NumSeats { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public CustomerNoTicketDTO Customer { get; set; }

        public ScreeningsDTO Screening { get; set; }
    }
}
