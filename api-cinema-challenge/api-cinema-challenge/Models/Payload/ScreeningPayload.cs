﻿namespace api_cinema_challenge.Models.Payload
{
    public class ScreeningPayload
    {
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime StartsAt { get; set; }
    }
}
