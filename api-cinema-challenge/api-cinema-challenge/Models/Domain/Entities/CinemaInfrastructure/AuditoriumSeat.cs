﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.Domain.Entities.CinemaInfrastructure
{
    [Table("auditorium_seats")]
    public class AuditoriumSeat
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("auditorium_id")]
        [ForeignKey("AuditoriumId")]
        public int AuditoriumId { get; set; }
        public Auditorium Auditorium { get; set; }

        [Column("row_number")]
        public int RowNumber { get; set; }

        [Column("seat_number")]
        public int SeatNumber { get; set; }
    }
}
