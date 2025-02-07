namespace api_cinema_challenge.DTO.Response
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<TicketCustomerDTO> Tickets { get; set; } = new List<TicketCustomerDTO>();
    }
}
