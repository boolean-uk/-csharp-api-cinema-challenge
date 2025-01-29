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

            cinema.MapGet("/", GetAllMovies);


        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllMovies(IRepository<Movie> movieRepo)
        {
            var results = await movieRepo.GetAll();
            List<MovieDTO> movieDTOs = new List<MovieDTO>();
            results.ToList().ForEach(x => movieDTOs.Add(new MovieDTO(x)));
            return TypedResults.Ok(movieDTOs);
        }
    }
}