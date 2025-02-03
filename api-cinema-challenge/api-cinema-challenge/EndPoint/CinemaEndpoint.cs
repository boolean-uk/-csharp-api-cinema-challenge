using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.EndPoint
{
    public static class CinemaEndpoint
    {
        public static void ConfigureCinemaEndPoint (this WebApplication app)
        {
            app.MapPost("/customers", AddCustomer);
            app.MapGet("/customers", GetCustomers);
            app.MapPut("/customers/{id}", UpdateCustomer);
            app.MapDelete("/customers/{id}", DeleteCustomer);

            app.MapPost("/movies", AddMovie);
            app.MapGet("/movies", GetMovies);
            app.MapPut("/movies/{id}", UpdateMovie);
            app.MapDelete("movies/{id}", DeleteMovie);

            app.MapPost("/movies/{id}/screenings", AddScreening);
            app.MapGet("movies/{id}/screenings", GetScreenings);


        }
        public static async Task<IResult> AddCustomer(IRepository repo, CustomerPost customer)
        {
            Customer result = new Customer
            {
                Name = customer.name,
                Email = customer.email,
                Phone = customer.phone,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };
            await repo.AddCustomer(result);

            return TypedResults.Ok(result);
        }
        public static async Task<IResult> GetCustomers(IRepository repo)
        {
            var customers = await repo.GetCustomers();

            return TypedResults.Ok(customers);
        }
        public static async Task<IResult> UpdateCustomer(IRepository repo, CustomerPost customer, int id)
        {
            var customerReturned = await repo.GetCustomer(id);
            if (customerReturned == null)
            {
                return TypedResults.NotFound();
            }
            if (customer.name != null) customerReturned.Name = customer.name;
            if (customer.email != null) customerReturned.Email = customer.email;
            if (customer.phone != null) customerReturned.Phone = customer.phone;

            var updated = await repo.UpdateCustomer(customerReturned, id);

            return TypedResults.Ok(updated);
        }
        public static async Task<IResult> DeleteCustomer(IRepository repo, int id)
        {
            var deleted = await repo.DeleteCustomer(id);
            return TypedResults.Ok(deleted);
        }

        public static async Task<IResult> AddMovie(IRepository repo, MoviePost movie)
        {
            Movie result = new Movie
            {
                Title = movie.Title,
                Rating = movie.Rating,
                Description = movie.Description,
                RuntimeMins = movie.RuntimeMins,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };
            await repo.AddMovie(result);

            return TypedResults.Ok(result);

        }
        public static async Task<IResult> GetMovies(IRepository repo)
        {
            var movies = await repo.GetMovies();

            var movieDTO = movies.Select(m => new MovieDTO
            {
                Title = m.Title,
                Rating = m.Rating,
                Description = m.Description,
                RuntimeMins = m.RuntimeMins,
                CreatedAt = m.CreatedAt,
                UpdatedAt = m.UpdatedAt,
                Screenings = m.Screenings.Select(s => new ScreeningDTO
                {
                    ScreenNumber = s.ScreenNumber,
                    Capacity = s.Capacity,
                    StartsAt = s.StartsAt,
                    MovieId = s.MovieId,
                    CreatedAt = s.CreatedAt,
                    UpdatedAt = s.UpdatedAt
                }).ToList()
            });
            return TypedResults.Ok(movies);
        }
        public static async Task<IResult> UpdateMovie(IRepository repo, MoviePost movie, int id)
        {
            var movieReturned = await repo.GetMovie(id);
            if (movieReturned == null)
            {
                return TypedResults.NotFound();
            }
            if (movie.Title != null) movieReturned.Title = movie.Title;
            if (movie.Rating != null) movieReturned.Rating = movie.Rating;
            if (movie.Description != null) movieReturned.Description = movie.Description;
            if (movie.RuntimeMins != null) movieReturned.RuntimeMins = movie.RuntimeMins;

            var updated = await repo.UpdateMovie(movieReturned, id);

            MovieDTO movieDTO = new MovieDTO
            {
                Title = movieReturned.Title,
                Rating = movieReturned.Rating,
                Description = movieReturned.Description,
                RuntimeMins = movieReturned.RuntimeMins,
                CreatedAt = movieReturned.CreatedAt,
                UpdatedAt = movieReturned.UpdatedAt,
                Screenings = movieReturned.Screenings.Select(s => new ScreeningDTO
                {
                    ScreenNumber = s.ScreenNumber,
                    Capacity = s.Capacity,
                    StartsAt = s.StartsAt,
                    MovieId = s.MovieId,
                    CreatedAt = s.CreatedAt,
                    UpdatedAt = s.UpdatedAt
                }).ToList()
            };
            return TypedResults.Ok(movieDTO);
        }
        public static async Task<IResult> DeleteMovie(IRepository repo, int id)
        {
            var deleted = await repo.DeleteMovie(id);
            return TypedResults.Ok(deleted);
        }

        public static async Task<IResult> AddScreening(IRepository repo, ScreeningPost screening, int id)
        {
            Screening result = new Screening
            {
                ScreenNumber = screening.ScreenNumber,
                Capacity = screening.Capacity,
                StartsAt = screening.StartsAt,
                MovieId = screening.MovieId,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };
            await repo.AddScreening(result);

            return TypedResults.Ok(result);

        }
        public static async Task<IResult> GetScreenings(IRepository repo, int movieId)
        {
            var result = await repo.GetScreenings(movieId);
            var screenings = result.Select(s => new ScreeningDTOBig
            {
                ScreenNumber = s.ScreenNumber,
                Capacity = s.Capacity,
                StartsAt = s.StartsAt,
                MovieId = s.MovieId,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                Movie = new MovieSmall
                {
                    Title = s.Movie.Title,
                    Rating = s.Movie.Rating,
                    Description = s.Movie.Description,
                    RuntimeMins = s.Movie.RuntimeMins,
                    CreatedAt = s.Movie.CreatedAt,
                    UpdatedAt = s.Movie.UpdatedAt
                }
            });
            
            return TypedResults.Ok(screenings);
        }
    }
}
