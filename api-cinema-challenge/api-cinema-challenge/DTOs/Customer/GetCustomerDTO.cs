﻿namespace api_cinema_challenge.DTOs.Customer
{
    public class GetCustomerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<GetTicketForCustomerDTO> Tickets { get; set; }
    }
}
