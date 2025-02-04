using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using api_cinema_challenge.Models;

namespace api_cinema_challenge
{
    [Table("movies")]
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("rating")]
        public string Rating { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("runtimeMins")]
        public int RuntimeMins { get; set; }

        [Column("createdAt")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("updatedAt")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public virtual ICollection<Screening> Screenings { get; set; } = new List<Screening>();

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
