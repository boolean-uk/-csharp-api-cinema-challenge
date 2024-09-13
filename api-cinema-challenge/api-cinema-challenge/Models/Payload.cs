﻿namespace api_cinema_challenge.Models
{
    public class Payload<T> where T : class
    {
        public string status { get; set; }
        public T data { get; set; }
    }
}
