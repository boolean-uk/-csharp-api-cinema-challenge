﻿using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTOs
{
    public class DTOMovieObject
    {

        public int Id {  get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Rating { get; set; }
        public int RuntimeMins { get; set; }
        public IEnumerable<Screening> Screenings { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
