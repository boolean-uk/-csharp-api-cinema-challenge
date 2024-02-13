﻿using System.Net.NetworkInformation;

namespace api_cinema_challenge.DTO.DTO_Movie
{
    public class MovieBaseDTO
    {
        public string status { get; set; }

        public MovieDTO data { get; set; }

        public MovieBaseDTO(MovieDTO movie)
        {
            status = "success";
            data = movie;
        }
    }
}
