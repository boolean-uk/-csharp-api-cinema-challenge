﻿namespace api_cinema_challenge.ServiceResponse
{
    public class ServiceResponse<T>
    {
        public string Status { get; set; }
        public T Data { get; set; }
        //public string Messenge { get; set; }   
    }
}
