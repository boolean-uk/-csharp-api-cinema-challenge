using api_cinema_challenge.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.DTO
{
    public class TicketDTO
    {
        
        public int ticketId { get; set; }
        
        public Screen screen { get; set; }
        
        public int customerID { get; set; }
   
        public virtual string customer { get; set; }

        public TicketDTO(Ticket ticket) 
        {
            ticketId = ticket.ticketId;
            screen = ticket.screen;
            customerID = ticket.customerID;
            //fill in customer 
            throw new NotImplementedException();
        }
    }

}
