using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("Customer")]
    [PrimaryKey("customerId")]
    public class Customer
    {
        [Column("customerId")]
        public int customerId { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        [Column("Email")]
        public string Email { get; set; }
        [Column("Phone")]
        public string Phone { get; set; }
        [Column("CreatedAt")]
        public string CreatedAt { get; set; }
        [Column("UpdatedAt")]
        public string UpdatedAt { get; set; }
        [NotMapped]
        public virtual List<Ticket> tickets { get; set; } = new List<Ticket>();
        [NotMapped]
        public int ticketId { get; set; }


    }
}
