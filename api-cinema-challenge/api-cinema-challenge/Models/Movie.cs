﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace api_cinema_challenge.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Rating is required")]
        public string Rating { get; set; }
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        [Required(ErrorMessage = "RunTimeMins is required")]
        public int RunTimeMins { get; set; }

        [JsonIgnore]
        public DateTime CreatedAt { get; set; }
        [JsonIgnore]
        public DateTime UpdatedAt { get; set; }
    }
}
