﻿using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("tickets")]
    public class Tickets
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("num_seats")]
        public int NumSeats { get; set; }

        [Column("screening_id")]
        public int ScreeningId { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.Now.ToUniversalTime();
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now.ToUniversalTime();
    }
}
