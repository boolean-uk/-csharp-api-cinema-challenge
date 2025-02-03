using api_cinema_challenge.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.DTO
{
    public class CustomerDTO
    {
        [Column("customerId")]
        public int customerId { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        [Column("Email")]
        public string Email { get; set; }
        [Column("Phone")]
        public string Phone { get; set; }
        [Column("CreatedAt")]
        public string CreatedAt { get; set; }
        [Column("UpdatedAt")]
        public string UpdatedAt { get; set; }
        [Column("tickets")]
        public virtual List<string> tickets { get; set; } = new List<string>();
        
        public CustomerDTO(Customer customer)
        {
            customerId = customer.customerId;
            Name = customer.Name;
            Email = customer.Email;
            Phone = customer.Phone;
            CreatedAt = customer.CreatedAt.ToString();
            UpdatedAt = customer.UpdatedAt.ToString();
            //making ticket dtos 
            customer.tickets.ForEach(x => tickets.Add($" screenNumber: {x.screen.screenNumber} "));
        }
    }
}
