using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Models
{
    //你看不懂这个吧
    [Table("Ticket")]
    [PrimaryKey("ticketId")]
    public class Ticket
    {
        [Column("ticketId")]
        public int ticketId { get; set; }
        [Column("screen")]
        public Screen screen { get; set; }
        [Column("screenId")]
        public int screenId { get; set; }
        [Column("customerId")]
        public int customerID { get; set; }
        [Column("customer")]
        public Customer customer {  get; set; }   
    }
}
