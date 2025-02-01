using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Models
{
    [Table("Screen")]
    [PrimaryKey("screenId")]
    public class Screen
    {
        [Column("screenId")]
        public int screenId { get; set; }
        [Column("screenNumber")]
        public int screenNumber { get; set; }
        [Column("capacity")]
        public int capacity { get; set; }
        [Column("startsAt")]
        public string startsAt { get; set; }
        [Column("createdAt")]
        public string createdAt { get; set; }
        [Column("UpdatedAt")]
        public string updatedAt { get; set; }
        [Column("movieId")]
        public int movieId{ get; set; }
        [NotMapped]
        public virtual Movie movie{ get; set; }
        [NotMapped]
        public virtual List<Ticket> tickets{ get; set; }
    }
}
