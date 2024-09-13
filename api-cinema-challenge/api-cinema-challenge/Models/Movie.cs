﻿using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace api_cinema_challenge.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        [JsonIgnore]
        public List<Screening> Screenings { get; set; } = new List<Screening>();

        public Movie()
        {

        }

        public Movie(int id, string title, string rating, string desc, int runtimeMins)
        {
            Id = id;
            Title = title;
            Rating = rating;
            Description = desc;
            RuntimeMins = runtimeMins;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = CreatedAt;
        }
    }
}
