﻿using api_cinema_challenge.Models.JunctionModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.PureModels
{
    [Table("displays")]
    public class Display
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("display_id")]
        public int DisplayId { get; set; }

        /// <summary>
        /// This ScreenNumber variable is only here so that a user can input due to the Post Screening definition schema.
        /// You can image it as having multiple configurations for the same display, same screen number but different DisplayIds
        /// </summary>
        [Column("screen_number")]
        public int ScreenNumber { get; set; }

        [Column("capacity")]
        public int Capacity { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set;}

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set;}

        public ICollection<TicketSeat> Seats { get; set; } = new List<TicketSeat>();

        public ICollection<Screening> Screenings { get; set; } = new List<Screening>();
    }
}
