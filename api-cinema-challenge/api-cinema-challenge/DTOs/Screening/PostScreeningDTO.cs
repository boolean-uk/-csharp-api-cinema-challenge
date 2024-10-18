﻿namespace api_cinema_challenge.DTOs.Screening
{
    public class PostScreeningDTO
    {
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public int MovieId { get; set; }
        public DateTime StartsAt { get; set; }
    }
}
