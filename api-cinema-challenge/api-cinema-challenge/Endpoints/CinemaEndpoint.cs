using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Reflection.Emit;
using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class CinemaEndpoint
    {
        public static void ConfigureCinema(this WebApplication app)
        {
            var cinema = app.MapGroup("/cinema");

            cinema.MapGet("/movies", GetAllMovies);
            cinema.MapPost("/newmovie", CreateMovie);
            cinema.MapPut("/updatemovie", UpdateMovie);
            cinema.MapDelete("/deletemovie", DeleteMovie);

            cinema.MapGet("/customers", GetAllCustomers);
            cinema.MapPost("/newcustomer", CreateCustomer);
            cinema.MapPut("/updatecustomer", UpdateCustomer);
            cinema.MapDelete("/deletecustomer", DeleteCustomer);

            cinema.MapGet("/tickets", GetAllTickets);
            cinema.MapPost("/newticket", CreateTicket);


            cinema.MapGet("/screens", GetAllScreens);
            cinema.MapPost("/newscreen", CreateScreen);


        }
        #region Movies
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> GetAllMovies(IRepository<Movie> movieRepo)
        {
            var results = movieRepo.GetAll();
            List<MovieDTO> movieDTOs = new List<MovieDTO>();
            results.ToList().ForEach(x => movieDTOs.Add(new MovieDTO(x)));
            return TypedResults.Ok(movieDTOs);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateMovie(IRepository<Movie> repo, string title, string runtime, string description, string rating)
        {

            try
            {
                Movie movie = new Movie { CreatedAt = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc).ToString(), Description = description, Title = title, RuntimeMins = runtime, Rating = rating, UpdatedAt = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc).ToString() };
                repo.Insert(movie);
                repo.Save();
                return TypedResults.Ok(movie);
            }
            catch (Exception e)
            {
                return TypedResults.BadRequest(e);
            }

        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> UpdateMovie(IRepository<Movie> repo, int id, string title, string runtime, string description, string rating)
        {
            try
            {
                Movie movie = repo.GetById(id);
                movie.Title = title;
                movie.Description = description;
                movie.RuntimeMins = runtime;
                movie.Rating = rating;
                movie.UpdatedAt = DateTime.Now.ToString();

                repo.Save();
                return TypedResults.Ok(new MovieDTO(movie));
            }
            catch (Exception ex)
            {
                return TypedResults.BadRequest(ex);
            }
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> DeleteMovie(IRepository<Movie> repo, int id)
        {
            try
            {
                repo.Delete(id);

                repo.Save();
                return TypedResults.Ok();
            }
            catch (Exception ex)
            {
                return TypedResults.BadRequest(ex);
            }
        }


        #endregion

        #region Customers
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> GetAllCustomers(IRepository<Customer> customerRepo)
        {
            var results = customerRepo.GetAll();
            List<CustomerDTO> customerDTOs = new List<CustomerDTO>();
            results.ToList().ForEach(x => customerDTOs.Add(new CustomerDTO(x)));
            return TypedResults.Ok(customerDTOs);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateCustomer(IRepository<Customer> repo, string name, string email, string phone)
        {

            try
            {
                Customer customer = new Customer { CreatedAt = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc).ToString(), Name = name, Email = email, Phone = phone, UpdatedAt = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc).ToString() };
                repo.Insert(customer);
                repo.Save();
                return TypedResults.Ok(customer);
            }
            catch (Exception e)
            {
                return TypedResults.BadRequest(e);
            }

        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> UpdateCustomer(IRepository<Customer> repo, int id, string name, string email, string phone)
        {
            try
            {
                Customer customer = repo.GetById(id);
                customer.Name = name;
                customer.Email = email;
                customer.Phone = phone;
                customer.UpdatedAt = DateTime.Now.ToString();

                repo.Save();
                return TypedResults.Ok(new CustomerDTO(customer));
            }
            catch (Exception ex)
            {
                return TypedResults.BadRequest(ex);
            }
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> DeleteCustomer(IRepository<Customer> repo, int id)
        {
            try
            {
                repo.Delete(id);

                repo.Save();
                return TypedResults.Ok();
            }
            catch (Exception ex)
            {
                return TypedResults.BadRequest(ex);
            }
        }
        #endregion
        #region Tickets
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> GetAllTickets(IRepository<Ticket> ticketRepo)
        {
            var results = ticketRepo.GetAll();
            List<TicketDTO> ticketDTOs = new List<TicketDTO>();
            results.ToList().ForEach(x => ticketDTOs.Add(new TicketDTO(x)));
            return TypedResults.Ok(ticketDTOs);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateTicket(IRepository<Ticket> repo, int customerId, int screenId)
        {


            Ticket ticket = new Ticket { customerID = customerId, screenId = screenId };
            repo.Insert(ticket);
            repo.Save();
            return TypedResults.Ok();



        }




        #endregion
        #region Screens
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> GetAllScreens(IRepository<Screen> screenRepo)
        {
            var results = screenRepo.GetAll();
            List<ScreenDTO> screenDTOs = new List<ScreenDTO>();
            results.ToList().ForEach(x => screenDTOs.Add(new ScreenDTO(x)));
            return TypedResults.Ok(screenDTOs);
        }
        #endregion
        #region MovieScreenings
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> GetAllScreenings(IRepository<Screen> screeningRepo)
        {
            var results = screeningRepo.GetAll();
            List<ScreenDTO> screeningDTOs = new List<ScreenDTO>();
            results.ToList().ForEach(x => screeningDTOs.Add(new ScreenDTO(x)));
            return TypedResults.Ok(screeningDTOs);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateScreen(IRepository<Screen> repo, int capacity, int screenNumber, string startsAt, int movieId)
        {
            try
            {
                Screen screen = new Screen { capacity = capacity, movieId = movieId, createdAt = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc).ToString(), screenNumber = screenNumber, startsAt = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc).ToString(), updatedAt = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc).ToString() };
                repo.Insert(screen);
                repo.Save();
                return TypedResults.Ok();
            }
            catch (Exception e)
            {
                return TypedResults.BadRequest(e);
            }

            #endregion
        }
    }
}