﻿namespace api_cinema_challenge.Models.Movie
{
    public class MovieInput
    {
        public string title { get; set; }
        public int rating { get; set; }
        public string description { get; set; }
        public int runtimeMins { get; set; }
    }
}
