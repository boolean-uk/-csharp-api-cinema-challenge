using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("tickets")]
    public class Ticket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("numSeats")]
        public int NumSeats { get; set; }

        [Column("createdAt")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("updatedAt")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        [ForeignKey("ScreeningId")]
        public int ScreeningId { get; set; }
        public virtual Screening Screening { get; set; }

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
