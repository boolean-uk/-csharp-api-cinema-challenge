﻿namespace api_cinema_challenge.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public int SeatId { get; set; }
        public Seat Seat { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int ScreeningId { get; set; }
        public Screening Screening { get; set; }
    }
}
