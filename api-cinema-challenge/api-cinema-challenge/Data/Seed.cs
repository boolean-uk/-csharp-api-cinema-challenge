using api_cinema_challenge.Models;

namespace api_cinema_challenge.Data
{
    public static class Seed
    {
        private static readonly Random Random = new Random();

        public async static Task SeedDatabase(this WebApplication app)
        {
            using (var db = new DataContext())
            {
                // Seed Movies
                if (!db.Movies.Any())
                {
                    var movies = new List<Movie>
                    {
                        new Movie { Title = "Inception", Rating = "PG-13", Description = "A mind-bending thriller", RuntimeMins = 148, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                        new Movie { Title = "The Matrix", Rating = "R", Description = "A sci-fi classic", RuntimeMins = 136, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
                    };
                    db.Add(movies);
                    await db.SaveChangesAsync();
                }

                // Seed Customers
                if (!db.Customers.Any())
                {
                    var customers = new List<Customer>
                    {
                        new Customer { Name = "John Doe", Email = "john@example.com", Phone = "123-456-7890", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                        new Customer { Name = "Jane Smith", Email = "jane@example.com", Phone = "987-654-3210", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
                    };
                    db.Add(customers);
                    await db.SaveChangesAsync();
                }

                // Ensure movies exist before adding screenings
                var movie1 = db.Movies.FirstOrDefault(m => m.Title == "Inception");
                var movie2 = db.Movies.FirstOrDefault(m => m.Title == "The Matrix");

                // Seed Screenings
                if (!db.Screenings.Any() && movie1 != null && movie2 != null)
                {
                    var screenings = new List<Screening>
                    {
                        new Screening { ScreenNumber = 5, Capacity = 100, StartsAt = DateTime.UtcNow.AddDays(1), MovieId = movie1.Id, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                        new Screening { ScreenNumber = 3, Capacity = 80, StartsAt = DateTime.UtcNow.AddDays(2), MovieId = movie2.Id, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
                    };
                    db.Add(screenings);
                    await db.SaveChangesAsync();
                }

                // Ensure customers and screenings exist before adding tickets
                var customer1 = db.Customers.FirstOrDefault(c => c.Name == "John Doe");
                var customer2 = db.Customers.FirstOrDefault(c => c.Name == "Jane Smith");
                var screening1 = db.Screenings.FirstOrDefault(s => s.ScreenNumber == 5);
                var screening2 = db.Screenings.FirstOrDefault(s => s.ScreenNumber == 3);

                // Seed Tickets
                if (!db.Tickets.Any() && customer1 != null && customer2 != null && screening1 != null && screening2 != null)
                {
                    var tickets = new List<Ticket>
                    {
                        new Ticket { NumSeats = 2, CustomerId = customer1.Id, ScreeningId = screening1.Id, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                        new Ticket { NumSeats = 3, CustomerId = customer2.Id, ScreeningId = screening2.Id, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
                    };
                    db.Add(tickets);
                    await db.SaveChangesAsync();
                }
            }
        }
    }
}
