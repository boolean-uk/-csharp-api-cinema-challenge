using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
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
        [NotMapped]
        public virtual Screen screen { get; set; }
        [Column("screenId")]
        public int screenId { get; set; }
        [Column("customerId")]
        public int customerID { get; set; }
        [NotMapped]
 
        public virtual Customer customer {  get; set; }   
    }
}
