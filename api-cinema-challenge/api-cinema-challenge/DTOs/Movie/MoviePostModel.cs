﻿using api_cinema_challenge.DTOs.Screening;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace api_cinema_challenge.DTOs.Movie
{
    public class MoviePostModel
    {
        [Required(ErrorMessage = "Movie title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Rating is required")]
        public string Rating { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Runtime minutes is required")]
        public int RuntimeMins {  get; set; }

        
        public List<ScreeningPostModel>? Screenings {  get; set; } 
    }
}
