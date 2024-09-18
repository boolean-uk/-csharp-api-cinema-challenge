﻿using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("Tickets")]
    public class Ticket
    {
        public int Id { get; set; }
        public int NumSeats { get; set; }

        [ForeignKey(nameof(Movie))]
        public int MovieId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
