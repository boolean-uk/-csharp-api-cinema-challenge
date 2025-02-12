using api_cinema_challenge.DTO.Request;
using api_cinema_challenge.DTO.Response;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.Sockets;

namespace api_cinema_challenge.Endpoints
{
    public static class CinemaAPI
    {
        public static void ConfigureCinemaAPI(this WebApplication app)
        {
            var cinema = app.MapGroup("cinema");

            cinema.MapGet("/customers", GetCustomers);
            cinema.MapGet("/customers/{id}", GetCustomerById);
            cinema.MapPost("/customers", CreateCustomer);
            cinema.MapPut("/customers/{id}", UpdateCustomer);
            cinema.MapDelete("/customers/{id}", DeleteCustomer);

            cinema.MapGet("/movies", GetMovies);
            cinema.MapGet("/movies/{id}", GetMovieById);
            cinema.MapPost("/movies", CreateMovie);
            cinema.MapPut("/movies/{id}", UpdateMovie);
            cinema.MapDelete("/movies/{id}", DeleteMovie);

            cinema.MapGet("/screenings", GetScreenings);
            cinema.MapGet("/screenings/{id}", GetScreeningById);
            cinema.MapPost("/screenings", CreateScreening);
            cinema.MapPut("/screenings/{id}", UpdateScreening);
            cinema.MapDelete("/screenings/{id}", DeleteScreening);

            cinema.MapGet("/tickets", GetTickets);
            cinema.MapGet("/tickets/{id}", GetTicketById);
            cinema.MapPost("/tickets", CreateTicket);
            cinema.MapPut("/tickets/{id}", UpdateTicket);
            cinema.MapDelete("/tickets/{id}", DeleteTicket);
        }

        // Customer
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomers(IRepository<Customer> customerRepo)
        {

            var customersQuery = customerRepo.GetWithIncludes(c => c.Tickets);
            var customers = await customersQuery.Include(c => c.Tickets).ThenInclude(t => t.Screening).ThenInclude(s => s.Movie).ToListAsync();

            var result = customers.Select(c => new CustomerDTO
            {
                Id = c.Id,
                Name = c.Name,
                Email = c.Email,
                Tickets = c.Tickets.Select(t => new TicketCustomerDTO
                {
                    Id = t.Id,
                    ScreeningMovie = t.Screening.Movie.Name,
                    ScreeningTime = t.Screening.Time
                }).ToList()
            }).ToList();
            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetCustomerById(IRepository<Customer> customerRepo, int id)
        {
            var customersQuery = customerRepo.GetWithIncludes(c => c.Tickets);
            var customers = await customersQuery.Include(c => c.Tickets).ThenInclude(t => t.Screening).ThenInclude(s => s.Movie).ToListAsync();

            var customer = customers.FirstOrDefault(c => c.Id == id);

            if (customer == null) return TypedResults.NotFound($"No customer found for id {id}");

            var result = new CustomerDTO
            {
                Id = customer.Id,
                Name = customer.Name,
                Email = customer.Email,
                Tickets = customer.Tickets.Select(t => new TicketCustomerDTO
                {
                    Id = t.Id,
                    ScreeningMovie = t.Screening.Movie.Name,
                    ScreeningTime = t.Screening.Time
                }).ToList()
            };
            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateCustomer(IRepository<Customer> customerRepo, CustomerPost model)
        {
            if (string.IsNullOrWhiteSpace(model.Name) ||
                string.IsNullOrWhiteSpace(model.Email)) return Results.BadRequest("Customer's input was formatted wrong.");

            var customer = new Customer()
            {
                Name = model.Name,
                Email = model.Email,
            };

            customer = await customerRepo.Insert(customer);

            var result = new CustomerDTO
            {
                Id = customer.Id,
                Name = customer.Name,
                Email = customer.Email,
                Tickets = customer.Tickets.Select(t => new TicketCustomerDTO
                {
                    Id = t.Id,
                    ScreeningMovie = t.Screening.Movie.Name,
                    ScreeningTime = t.Screening.Time
                }).ToList()
            };
            return Results.Created($"/customers/{customer.Id}", result);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> UpdateCustomer(IRepository<Customer> customerRepo, int id, CustomerPut model)
        {
            if (string.IsNullOrWhiteSpace(model.Name) &&
                string.IsNullOrWhiteSpace(model.Email)) return Results.BadRequest("Customer's input was formatted wrong.");

            var customer = await customerRepo.GetById(id);
            if (customer == null) return Results.NotFound("Customer not found");
            if (model.Name != null) customer.Name = model.Name;
            if (model.Email != null) customer.Email = model.Email;

            customer = await customerRepo.Update(customer);

            var result = new CustomerDTO
            {
                Id = customer.Id,
                Name = customer.Name,
                Email = customer.Email,
                Tickets = customer.Tickets.Select(t => new TicketCustomerDTO
                {
                    Id = t.Id,
                    ScreeningMovie = t.Screening.Movie.Name,
                    ScreeningTime = t.Screening.Time
                }).ToList()
            };
            return Results.Created($"/customers/{customer.Id}", result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteCustomer(IRepository<Customer> customerRepo, int id)
        {
            var customer = await customerRepo.GetById(id);
            if (customer == null) return Results.NotFound("Customer not found");

            customer = await customerRepo.Delete(id);

            var result = new CustomerDTO
            {
                Id = customer.Id,
                Name = customer.Name,
                Email = customer.Email,
                Tickets = customer.Tickets.Select(t => new TicketCustomerDTO
                {
                    Id = t.Id,
                    ScreeningMovie = t.Screening.Movie.Name,
                    ScreeningTime = t.Screening.Time
                }).ToList()
            };

            return Results.Ok(result);
        }




        // Movie
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IRepository<Movie> movieRepo)
        {
            var movies = movieRepo.GetWithIncludes(m => m.Screenings);

            var result = movies.Select(c => new MovieDTO
            {
                Id = c.Id,
                Name = c.Name,
                Screenings = c.Screenings.Select(s => new ScreeningMovieDTO
                {
                    Id = s.Id,
                    Time = s.Time
                }).ToList()
            }).ToList();
            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetMovieById(IRepository<Movie> movieRepo, int id)
        {
            var movies = movieRepo.GetWithIncludes(m => m.Screenings);
            var movie = movies.FirstOrDefault(c => c.Id == id);

            if (movie == null) return TypedResults.NotFound($"No movie found for id {id}");

            var result = new MovieDTO
            {
                Id = movie.Id,
                Name = movie.Name,
                Screenings = movie.Screenings.Select(s => new ScreeningMovieDTO
                {
                    Id = s.Id,
                    Time = s.Time
                }).ToList()
            };
            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateMovie(IRepository<Movie> movieRepo, MoviePost model)
        {
            if (string.IsNullOrWhiteSpace(model.Name)) return Results.BadRequest("Movie's input was formatted wrong.");

            var movie = new Movie()
            {
                Name = model.Name,
            };

            movie = await movieRepo.Insert(movie);

            var result = new MovieDTO
            {
                Id = movie.Id,
                Name = movie.Name,
                Screenings = movie.Screenings.Select(s => new ScreeningMovieDTO
                {
                    Id = s.Id,
                    Time = s.Time
                }).ToList()
            };
            return Results.Created($"/movies/{movie.Id}", result);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> UpdateMovie(IRepository<Movie> movieRepo, int id, MoviePut model)
        {
            if (string.IsNullOrWhiteSpace(model.Name)) return Results.BadRequest("Movie's input was formatted wrong.");

            var movie = await movieRepo.GetById(id);
            if (movie == null) return Results.NotFound("Movie not found");
            if (model.Name != null) movie.Name = model.Name;

            movie = await movieRepo.Update(movie);

            var result = new MovieDTO
            {
                Id = movie.Id,
                Name = movie.Name,
                Screenings = movie.Screenings.Select(s => new ScreeningMovieDTO
                {
                    Id = s.Id,
                    Time = s.Time
                }).ToList()
            };
            return Results.Created($"/movies/{movie.Id}", result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteMovie(IRepository<Movie> movieRepo, int id)
        {
            var movie = await movieRepo.GetById(id);
            if (movie == null) return Results.NotFound("Movie not found");

            movie = await movieRepo.Delete(id);

            var result = new MovieDTO
            {
                Id = movie.Id,
                Name = movie.Name,
                Screenings = movie.Screenings.Select(s => new ScreeningMovieDTO
                {
                    Id = s.Id,
                    Time = s.Time
                }).ToList()
            };
            return Results.Ok(result);
        }



        // Screening
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetScreenings(IRepository<Screening> screeningRepo)
        {
            var screenings = screeningRepo.GetWithIncludes(s => s.Movie);

            var result = screenings.Select(s => new ScreeningDTO
            {
                Id = s.Id,
                Time = s.Time,
                MovieName = s.Movie.Name
            }).ToList();
            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetScreeningById(IRepository<Screening> screeningRepo, int id)
        {
            var screenings = screeningRepo.GetWithIncludes(s => s.Movie);
            var screening = screenings.FirstOrDefault(s => s.Id == id);

            if (screening == null) return TypedResults.NotFound($"No Screening found for id {id}");

            var result = new ScreeningDTO
            {
                Id = screening.Id,
                Time = screening.Time,
                MovieName = screening.Movie.Name
            };
            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateScreening(IRepository<Screening> screeningRepo, ScreeningPost model)
        {
            if (model.Time == null ||
                model.MovieId == null) return Results.BadRequest("Screening's input was formatted wrong.");

            var screening = new Screening()
            {
                Time = model.Time,
                MovieId = model.MovieId
            };

            screening = await screeningRepo.Insert(screening);


            var screenings = screeningRepo.GetWithIncludes(s => s.Movie);
            screening = screenings.FirstOrDefault(s => s.Id == screening.Id);

            var result = new ScreeningDTO
            {
                Id = screening.Id,
                Time = screening.Time,
                MovieName = screening.Movie.Name
            };
            return Results.Created($"/screenings/{screening.Id}", result);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> UpdateScreening(IRepository<Screening> screeningRepo, int id, ScreeningPut model)
        {
            if (model.Time == null ||
                model.MovieId == null) return Results.BadRequest("Screening's input was formatted wrong.");

            var screening = await screeningRepo.GetById(id);
            if (screening == null) return Results.NotFound("Screening not found");
            if (model.Time != null) screening.Time = (DateTime)model.Time;
            if (model.MovieId != null) screening.MovieId = (int)model.MovieId;

            screening = await screeningRepo.Update(screening);

            var result = new ScreeningDTO
            {
                Id = screening.Id,
                Time = screening.Time,
                MovieName = screening.Movie.Name
            };
            return Results.Created($"/screenings/{screening.Id}", result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteScreening(IRepository<Screening> screeningRepo, int id)
        {
            var screenings = screeningRepo.GetWithIncludes(s => s.Movie);
            var screening = screenings.FirstOrDefault(s => s.Id == id );
            if (screening == null) return Results.NotFound("Screening not found");

            await screeningRepo.Delete(id);

            var result = new ScreeningDTO
            {
                Id = screening.Id,
                Time = screening.Time,
                MovieName = screening.Movie.Name
            };

            return Results.Ok(result);
        }



        // Ticket
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetTickets(IRepository<Ticket> ticketRepo)
        {
            var ticketsQuery = ticketRepo.GetWithIncludes(t => t.Customer);
            var tickets = await ticketsQuery.Include(t => t.Customer).Include(t => t.Screening).ThenInclude(s => s.Movie).ToListAsync();
            
            var result = tickets.Select(t => new TicketDTO
            {
                Id = t.Id,
                CustomerName = t.Customer.Name,
                SceeringMovie = t.Screening.Movie.Name,
                SceeringTime = t.Screening.Time,
            }).ToList();
            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetTicketById(IRepository<Ticket> ticketRepo, int id)
        {
            var ticketsQuery = ticketRepo.GetWithIncludes(t => t.Customer);
            var tickets = await ticketsQuery.Include(t => t.Customer).Include(t => t.Screening).ThenInclude(s => s.Movie).ToListAsync();
            var ticket = tickets.FirstOrDefault(s => s.Id == id);

            if (ticket == null) return TypedResults.NotFound($"No Ticket found for id {id}");

            var result = new TicketDTO
            {
                Id = ticket.Id,
                CustomerName = ticket.Customer.Name,
                SceeringMovie = ticket.Screening.Movie.Name,
                SceeringTime = ticket.Screening.Time,
            };
            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateTicket(IRepository<Ticket> ticketRepo, TicketPost model)
        {
            if (model.CustomerId == null ||
                model.SceeringId == null) return Results.BadRequest("Ticket's input was formatted wrong.");

            var ticket = new Ticket()
            {
                CustomerId = model.CustomerId,
                SceeringId = model.SceeringId
            };

            ticket = await ticketRepo.Insert(ticket);

            var ticketsQuery = ticketRepo.GetWithIncludes(t => t.Customer);
            var tickets = await ticketsQuery.Include(t => t.Customer).Include(t => t.Screening).ThenInclude(s => s.Movie).ToListAsync();
            ticket = tickets.FirstOrDefault(s => s.Id == ticket.Id);

            var result = new TicketDTO
            {
                Id = ticket.Id,
                CustomerName = ticket.Customer.Name,
                SceeringMovie = ticket.Screening.Movie.Name,
                SceeringTime = ticket.Screening.Time,
            };
            return Results.Created($"/tickets/{ticket.Id}", result);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> UpdateTicket(IRepository<Ticket> ticketRepo, int id, TicketPut model)
        {
            if (model.CustomerId == null ||
                model.SceeringId == null) return Results.BadRequest("Ticket's input was formatted wrong.");

            var ticket = await ticketRepo.GetById(id);
            if (ticket == null) return Results.NotFound("Ticket not found");
            if (model.CustomerId != null) ticket.CustomerId = (int)model.CustomerId;
            if (model.SceeringId != null) ticket.SceeringId = (int)model.SceeringId;

            ticket = await ticketRepo.Update(ticket);

            var ticketsQuery = ticketRepo.GetWithIncludes(t => t.Customer);
            var tickets = await ticketsQuery.Include(t => t.Customer).Include(t => t.Screening).ThenInclude(s => s.Movie).ToListAsync();
            ticket = tickets.FirstOrDefault(s => s.Id == id);

            var result = new TicketDTO
            {
                Id = ticket.Id,
                CustomerName = ticket.Customer.Name,
                SceeringMovie = ticket.Screening.Movie.Name,
                SceeringTime = ticket.Screening.Time,
            };
            return Results.Created($"/tickets/{ticket.Id}", result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteTicket(IRepository<Ticket> ticketRepo, int id)
        {
            var ticketsQuery = ticketRepo.GetWithIncludes(t => t.Customer);
            var tickets = await ticketsQuery.Include(t => t.Customer).Include(t => t.Screening).ThenInclude(s => s.Movie).ToListAsync();
            var ticket = tickets.FirstOrDefault(s => s.Id == id);
            if (ticket == null) return Results.NotFound("Ticket not found");

            ticket = await ticketRepo.Delete(id);

            var result = new TicketDTO
            {
                Id = ticket.Id,
                CustomerName = ticket.Customer.Name,
                SceeringMovie = ticket.Screening.Movie.Name,
                SceeringTime = ticket.Screening.Time,
            };

            return Results.Ok(result);
        }
    }
}
