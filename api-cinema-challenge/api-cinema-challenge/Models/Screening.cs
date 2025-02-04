using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("screenings")]
    public class Screening
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("screenNumber")]
        public int ScreenNumber { get; set; }

        [Column("capacity")]
        public int Capacity { get; set; }

        [Column("startsAt")]
        public DateTime StartsAt { get; set; }

        [Column("createdAt")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("updatedAt")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        [ForeignKey("MovieId")]
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();

        public void OnCreate()
        {
            CreatedAt = DateTime.UtcNow;
        }

        public void OnUpdate()
        {
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
