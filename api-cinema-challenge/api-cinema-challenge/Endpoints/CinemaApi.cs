using api_cinema_challenge.DTO.CustomerDTO;
using api_cinema_challenge.DTO.MovieDTO;
using api_cinema_challenge.DTO.ScreeningDTO;
using api_cinema_challenge.DTO.TicketDTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using api_cinema_challenge;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using workshop.wwwapi.Repository;

namespace exercise.cinemaapi.EndPoints
{
    public static class CinemaApi
    {
        public static void ConfigureCinemaApi(this WebApplication app)
        {
            var cinema = app.MapGroup("cinema");

            cinema.MapGet("/customers", GetCustomers);
            cinema.MapGet("/movies", GetMovies);
            cinema.MapGet("/movies/{id}/screenings", GetScreenings);
            cinema.MapGet("/tickets", GetTickets);
            cinema.MapGet("/tickets/{id}", GetTicketById);

            cinema.MapPost("/customers", AddCustomer);
            cinema.MapPost("/movies", AddMovie);
            cinema.MapPost("/movies/{id}/screenings", AddScreening);
            cinema.MapPost("/tickets", AddTicket);

            cinema.MapPut("/customers/{id}", UpdateCustomer);
            cinema.MapPut("/movies/{id}", UpdateMovie);
            cinema.MapPut("/tickets/{id}", UpdateTicket);

            cinema.MapDelete("/customers/{id}", DeleteCustomer);
            cinema.MapDelete("/movies/{id}", DeleteMovie);
            cinema.MapDelete("/tickets/{id}", DeleteTicket);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomers(IRepository<Customer> repository, IMapper mapper)
        {
            var customers = await repository.GetWithNestedIncludes(query =>
                query.Include(p => p.Tickets)
                     .ThenInclude(a => a.Screening));
            var response = mapper.Map<List<CustomersDTO>>(customers);
            return TypedResults.Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IRepository<Movie> repository, IMapper mapper)
        {
            var movies = await repository.GetWithNestedIncludes(query =>
                query.Include(p => p.Screenings));
            var response = mapper.Map<List<MoviesDTO>>(movies);
            return TypedResults.Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetScreenings(IRepository<Screening> repository, IMapper mapper, int id)
        {
            var screenings = await repository.GetWithNestedIncludes(query =>
                query.Where(s => s.MovieId == id));

            var response = mapper.Map<List<ScreeningsDTO>>(screenings);
            return TypedResults.Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetTickets(IRepository<Ticket> repository, IMapper mapper)
        {
            var tickets = await repository.GetWithNestedIncludes(query =>
                query.Include(t => t.Customer)
                     .Include(t => t.Screening));
            var response = mapper.Map<List<TicketsDTO>>(tickets);
            return TypedResults.Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetTicketById(IRepository<Ticket> repository, IMapper mapper, int id)
        {
            var ticket = await repository.GetWithNestedIncludes(query =>
                query.Where(t => t.Id == id)
                     .Include(t => t.Customer)
                     .Include(t => t.Screening));
            if (ticket == null) return TypedResults.NotFound();

            var response = mapper.Map<TicketsDTO>(ticket.FirstOrDefault());
            return TypedResults.Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> AddCustomer(IRepository<Customer> repository, IMapper mapper, CreateCustomerDTO customerDto)
        {
            var customer = mapper.Map<Customer>(customerDto);
            await repository.Add(customer);
            return TypedResults.Created($"/cinema/customers/{customer.Id}", customer);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> AddMovie(IRepository<Movie> repository, IMapper mapper, CreateMovieDTO movieDto)
        {
            var movie = mapper.Map<Movie>(movieDto);
            await repository.Add(movie);
            return TypedResults.Created($"/cinema/movies/{movie.Id}", movie);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> AddScreening(IRepository<Screening> repository, IMapper mapper, int id, CreateScreeningDTO screeningDto)
        {
            var screening = mapper.Map<Screening>(screeningDto);
            screening.MovieId = id;
            await repository.Add(screening);
            return TypedResults.Created($"/cinema/movies/{id}/screenings/{screening.Id}", screening);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> AddTicket(IRepository<Ticket> repository, IRepository<Customer> customerRepo, IRepository<Screening> screeningRepo, IMapper mapper, int customerId, int screeningId, CreateTicketDTO ticketDto)
        {
            var customer = await customerRepo.GetById(customerId);
            var screening = await screeningRepo.GetById(screeningId);

            if (customer == null || screening == null) return TypedResults.BadRequest("Invalid customer or screening ID");

            //var ticket = new Ticket { CustomerId = customerId, ScreeningId = screeningId, Customer = customer, Screening = screening };
            var tickets = new Ticket
            {
                CustomerId = customerId,
                Customer = customer,
                ScreeningId = screeningId,
                Screening = screening
            };
            //var ticket = mapper.Map<Ticket>(tickets);
            await repository.Add(tickets);
            var saveTicket = await repository.GetById(tickets.Id);
            var response = mapper.Map<TicketsDTO>(saveTicket);
            return TypedResults.Created($"/cinema/tickets/{saveTicket.Id}", response);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> UpdateCustomer(IRepository<Customer> repository, IMapper mapper, int id, CreateCustomerDTO customerDto)
        {
            var existingCustomer = await repository.GetById(id);
            if (existingCustomer == null) return TypedResults.NotFound();

            mapper.Map(customerDto, existingCustomer);
            await repository.Update(existingCustomer);
            return TypedResults.Ok(existingCustomer);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> UpdateMovie(IRepository<Movie> repository, IMapper mapper, int id, CreateMovieDTO movieDto)
        {
            var existingMovie = await repository.GetById(id);
            if (existingMovie == null) return TypedResults.NotFound();

            mapper.Map(movieDto, existingMovie);
            await repository.Update(existingMovie);
            return TypedResults.Ok(existingMovie);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> UpdateTicket(IRepository<Ticket> repository, IMapper mapper, int id, CreateTicketDTO ticketDto)
        {
            var existingTicket = await repository.GetById(id);
            if (existingTicket == null) return TypedResults.NotFound();

            mapper.Map(ticketDto, existingTicket);
            await repository.Update(existingTicket);
            return TypedResults.Ok(existingTicket);
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public static async Task<IResult> DeleteCustomer(IRepository<Customer> repository, int id)
        {
            var existingCustomer = await repository.GetById(id);
            if (existingCustomer == null) return TypedResults.NotFound();

            await repository.Delete(existingCustomer);
            return TypedResults.NoContent();
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public static async Task<IResult> DeleteMovie(IRepository<Movie> repository, int id)
        {
            var existingMovie = await repository.GetById(id);
            if (existingMovie == null) return TypedResults.NotFound();

            await repository.Delete(existingMovie);
            return TypedResults.NoContent();
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public static async Task<IResult> DeleteTicket(IRepository<Ticket> repository, int id)
        {
            var existingTicket = await repository.GetById(id);
            if (existingTicket == null) return TypedResults.NotFound();

            await repository.Delete(existingTicket);
            return TypedResults.NoContent();
        }
    }
}
