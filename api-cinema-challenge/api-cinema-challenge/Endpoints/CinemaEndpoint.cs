using System.Reflection.Emit;
using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class CinemaEndpoint
    {
        public static void ConfigureCinema(this WebApplication app)
        {
            var cinema = app.MapGroup("/cinema");

            cinema.MapGet("/movies", GetAllMovies);
            cinema.MapGet("/customers", GetAllMovies);
            cinema.MapGet("/tickets", GetAllTickets);
            cinema.MapGet("/screens", GetAllScreens);

        }
        #region Movies
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllMovies(IRepository<Movie> movieRepo)
        {
            var results = await movieRepo.GetAll();
            List<MovieDTO> movieDTOs = new List<MovieDTO>();
            results.ToList().ForEach(x => movieDTOs.Add(new MovieDTO(x)));
            return TypedResults.Ok(movieDTOs);
        }
        #endregion

        #region Customers
        public static async Task<IResult> GetAllCustomers(IRepository<Customer> customerRepo)
        {
            var results = await customerRepo.GetAll();
            List<CustomerDTO> customerDTOs = new List<CustomerDTO>();
            results.ToList().ForEach(x => customerDTOs.Add(new CustomerDTO(x)));
            return TypedResults.Ok(customerDTOs);
        }
        #endregion
        #region Tickets
        public static async Task<IResult> GetAllTickets(IRepository<Ticket> ticketRepo)
        {
            var results = await ticketRepo.GetAll();
            List<TicketDTO> ticketDTOs = new List<TicketDTO>();
            results.ToList().ForEach(x => ticketDTOs.Add(new TicketDTO(x)));
            return TypedResults.Ok(ticketDTOs);
        }
        #endregion
        #region Screens
        public static async Task<IResult> GetAllScreens(IRepository<Screen> screenRepo)
        {
            var results = await screenRepo.GetAll();
            List<ScreenDTO> screenDTOs = new List<ScreenDTO>();
            results.ToList().ForEach(x => screenDTOs.Add(new ScreenDTO(x)));
            return TypedResults.Ok(screenDTOs);
        }
        #endregion
        #region MovieScreenings
        public static async Task<IResult> GetAllScreenings(IRepository<MovieOnScreen> screeningRepo)
        {
            var results = await screeningRepo.GetAll();
            List<MovieOnScreenDTO> screeningDTOs = new List<MovieOnScreenDTO>();
            results.ToList().ForEach(x => screeningDTOs.Add(new MovieOnScreenDTO(x)));
            return TypedResults.Ok(screeningDTOs);
        }
        #endregion
    }
}