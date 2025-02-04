using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.DTO.CustomerDTO
{
    public class CreateCustomerDTO
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

    }
}
