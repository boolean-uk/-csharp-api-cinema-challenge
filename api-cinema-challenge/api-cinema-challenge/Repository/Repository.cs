using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace api_cinema_challenge.Repository
{
    public class Repository : IRepository
    {
        CinemaContext _db;
        public Repository(CinemaContext db)
        {
            _db = db;
        }

        public async Task<Customer> AddCustomer(Customer customer)
        {
            await _db.Customers.AddAsync(customer);
            await _db.SaveChangesAsync();
            return customer;
        }

        public async Task<Movie> AddMovie(Movie movie)
        {
            await _db.Movies.AddAsync(movie);
            await _db.SaveChangesAsync();
            return movie;
        }

        public async Task<Screening> AddScreening(Screening screening)
        {
            var movie = await _db.Movies.FirstOrDefaultAsync(x => x.Id == screening.MovieId);
            if (movie == null)
            {
                return null;
            }
            screening.Movie = movie;
            await _db.Screenings.AddAsync(screening);
            await _db.SaveChangesAsync();
            return screening;
        }

        public async Task<Customer> DeleteCustomer(int id)
        {
            var result = await _db.Customers.FindAsync(id);
            _db.Customers.Remove(result);
            await _db.SaveChangesAsync();
            return result;
        }

        public async Task<Movie> DeleteMovie(int id)
        {
            var result = await _db.Movies.FindAsync(id);
            _db.Movies.Remove(result);
            await _db.SaveChangesAsync();
            return result;
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await _db.Customers.ToListAsync();
        }
        public async Task<Customer> GetCustomer(int id)
        {
            return await _db.Customers.FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<IEnumerable<Movie>> GetMovies()
        {
            return await _db.Movies.Include(x => x.Screenings).ToListAsync();
        }
        public async Task<Movie> GetMovie(int id)
        {
            return await _db.Movies.Include(b => b.Screenings).FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<IEnumerable<Screening>> GetScreenings(int id)
        {
            return await _db.Screenings.Include(x => x.Movie).Where(x => x.MovieId == id).ToListAsync();
        }

        public async Task<Customer> UpdateCustomer(Customer customer, int id)
        {
            var result = await _db.Customers.FindAsync(id);
            if (result == null) 
            {
                return null;
            }
            customer.Name = result.Name;
            customer.Email = result.Email;
            customer.Phone = result.Phone;
            customer.UpdatedAt = DateTime.UtcNow;

            await _db.SaveChangesAsync();
            return customer;
        }

        public async Task<Movie> UpdateMovie(Movie movie, int id)
        {
            var result = await _db.Movies.FindAsync(id);
            if (result == null)
            {
                return null;
            }
            movie.Title = result.Title;
            movie.Rating = result.Rating;
            movie.Description = result.Description;
            movie.RuntimeMins = result.RuntimeMins;
            movie.UpdatedAt = DateTime.UtcNow;

            await _db.SaveChangesAsync();
            return movie;
        }
    }
}
