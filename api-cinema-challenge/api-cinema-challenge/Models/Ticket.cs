﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.Models
{
    [Table("tickets")]
    public class Ticket
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("num_seats")]
        public int NumSeats { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        [ForeignKey("Customer")]
        [Column("customer_id")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [ForeignKey("Screening")]
        [Column("screening_id")]
        public int ScreeningId { get; set; }
        public Screening Screening { get; set; }
    }
}
