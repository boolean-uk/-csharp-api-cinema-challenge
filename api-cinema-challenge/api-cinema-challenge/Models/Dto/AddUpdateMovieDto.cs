﻿namespace api_cinema_challenge.Models.Dto
{
    public class AddUpdateMovieDto
    {
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }
    }
}
