﻿using api_cinema_challenge.Models.InputModels;
using api_cinema_challenge.Models.PureModels;
using api_cinema_challenge.Models.TransferModels.Payload;
using api_cinema_challenge.Models.TransferModels.Tickets;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class TicketsEndpoint
    {
        public static void ConfigureTicketsEndpoint(this WebApplication app) 
        {
            var ticketGroup = app.MapGroup("tickets/");

            ticketGroup.MapGet("/", GetTickets);
            ticketGroup.MapGet("/{id}", GetTicket);
            ticketGroup.MapGet("/ticket/{id}", GetTicketInformation);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetTickets(IRepository<Ticket> repo)
        {
            long startTicks = DateTime.Now.Ticks;
            IEnumerable<Ticket> tickets = await repo.GetAllIncluding();

            IEnumerable<TicketWithCustomerAndMovieDTO> ticketsOut = tickets
                .OrderByDescending(t => t.CreatedAt)
                .Select(t => new TicketWithCustomerAndMovieDTO(
                    t.TicketId, 
                    t.Seats.Count,
                    t.CreatedAt, 
                    t.UpdatedAt, 
                    t.Customer, 
                    t.Screening
                    ))
                .Take(400);
            int duration = (int)((DateTime.Now.Ticks - startTicks) / TimeSpan.TicksPerMillisecond);
            PayloadExtended<IEnumerable<TicketWithCustomerAndMovieDTO>> payload = 
                new PayloadExtended<IEnumerable<TicketWithCustomerAndMovieDTO>>(ticketsOut, duration, ticketsOut.Count());
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetTicket(IRepository<Ticket> repo, int id)
        {
            long startTicks = DateTime.Now.Ticks;
            Ticket? ticket = await repo.GetIncluding(id, "TicketId", (t => t.Customer));
            if (ticket == null) 
            {
                return TypedResults.NotFound($"No ticket with the provided ID {id} could be found.");
            }

            TicketDTO ticketOut = new TicketDTO(ticket.TicketId, ticket.Seats.Count(), ticket.CreatedAt, ticket.UpdatedAt);
            int duration = (int)((DateTime.Now.Ticks - startTicks)/TimeSpan.TicksPerMillisecond);
            PayloadExtended<TicketDTO> payload = new PayloadExtended<TicketDTO>(ticketOut, duration);
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetTicketInformation(IRepository<Ticket> repo, int id)
        {
            long startTicks = DateTime.Now.Ticks;
            Ticket? ticket = await repo.GetIncluding(id, "TicketId", (t => t.Seats));
            if (ticket == null)
            {
                return TypedResults.NotFound($"No ticket with the provided ID {id} could be found.");
            }

            TicketCustomerDTO ticketOut = new TicketCustomerDTO(ticket.Seats.Count, ticket.Customer, ticket.Seats.Select(ts => ts.Seat).ToList());
            int duration = (int)((DateTime.Now.Ticks - startTicks) / TimeSpan.TicksPerMillisecond);
            PayloadExtended<TicketCustomerDTO> payload = new PayloadExtended<TicketCustomerDTO>(ticketOut, duration);
            return TypedResults.Ok(payload);
        }
    }
}
