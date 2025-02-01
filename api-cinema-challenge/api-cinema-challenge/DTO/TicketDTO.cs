using api_cinema_challenge.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace api_cinema_challenge.DTO
{
    public class TicketDTO
    {
        
        public int ticketId { get; set; }
        
        public int screenNumber { get; set; }
        
        public int customerID { get; set; }
        [JsonIgnore]
        public string customer { get; set; }

 


        public TicketDTO(Ticket ticket) 
        {
            ticketId = ticket.ticketId;
            screenNumber = ticket.screen.screenNumber;
            customerID = ticket.customerID;
            //fill in customer 
            customer = ticket.customer.Name.ToString();
        }
    }

}
