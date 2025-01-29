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
        public DateTime startsAt { get; set; }
        [Column("createdAt")]
        public DateTime createdAt { get; set; }
        [Column("UpdatedAt")]
        public DateTime updatedAt { get; set; }
        [Column("tickets")]
        public List<Ticket> tickets { get; set; }
        [Column("movies")]
        public List<MovieOnScreen> moviesOnScreen { get; set; }
    }
}
