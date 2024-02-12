﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace api_cinema_challenge.Models.NewFolder
{
    public class Movie
    {
        [Key]
        [Column("movie_id")]
        public int Id { get; set; }
        [Column("movie_title")]
        public string Title { get; set; }
        [Column("movie_rating")]
        public string Rating { get; set; }
        [Column("movie_description")]
        public string Description { get; set; }
        [Column("movie_runtime")]
        public int Runtime { get; set; }
        [Column("movie_created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.Now.ToUniversalTime();
        [Column("movie_update_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now.ToUniversalTime();

        [JsonIgnore]
        public List<Screening> Screenings { get; set; }
    }
}
