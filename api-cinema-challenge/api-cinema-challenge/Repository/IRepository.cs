using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IRepository
    {
        Task<Customer> AddCustomer(Customer customer);
        Task<IEnumerable<Customer>> GetCustomers();
        Task<Customer> GetCustomer(int id);
        Task<Customer> UpdateCustomer(Customer customer, int id);
        Task<Customer> DeleteCustomer(int id);

        Task<Movie> AddMovie(Movie movie);
        Task<IEnumerable<Movie>> GetMovies();
        Task<Movie> GetMovie(int id);
        Task<Movie> UpdateMovie(Movie movie, int id);
        Task<Movie> DeleteMovie(int id);

        Task<Screening> AddScreening(Screening screening);
        Task<IEnumerable<Screening>> GetScreenings(int movieId);
    }
}
