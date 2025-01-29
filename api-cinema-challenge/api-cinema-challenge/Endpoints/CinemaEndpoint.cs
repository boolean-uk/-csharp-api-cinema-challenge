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

    }
}