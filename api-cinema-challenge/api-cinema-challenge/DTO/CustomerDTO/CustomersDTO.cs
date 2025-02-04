using System.ComponentModel.DataAnnotations.Schema;
using api_cinema_challenge.DTO.TicketDTO;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO.CustomerDTO
{
    public class CustomersDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public virtual ICollection<TicketsDTO> Tickets { get; set; } = new List<TicketsDTO>();
    }
}
