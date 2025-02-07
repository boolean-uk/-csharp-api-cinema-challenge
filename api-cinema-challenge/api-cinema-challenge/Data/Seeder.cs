using api_cinema_challenge.Models;

namespace api_cinema_challenge.Data
{
    public static class Seeder
    {
        public async static void SeedCinemaApi(this WebApplication app)
        {
            using (var db = new CinemaContext())
            {
                if (!db.Customers.Any())
                {
                    db.Add(new Customer() { Name = "Nigel", Email = "nigel@gmail.com"});
                    db.Add(new Customer() { Name = "Dave", Email = "dave@gmail.com"});
                    db.Add(new Customer() { Name = "Tonnes", Email = "tonnes@gmail.com" });
                    await db.SaveChangesAsync();
                }

                if (!db.Movies.Any())
                {
                    db.Add(new Movie() { Name = "Lord of the Rings" });
                    db.Add(new Movie() { Name = "Mission Impossible" });
                    db.Add(new Movie() { Name = "Harry Potter" });
                    await db.SaveChangesAsync();
                }
                
                if (!db.Screenings.Any())
                {
                    db.Add(new Screening() { MovieId = 1, Time = DateTime.SpecifyKind(new DateTime(2025, 1, 25, 11, 30, 0), DateTimeKind.Utc) });
                    db.Add(new Screening() { MovieId = 2, Time = DateTime.SpecifyKind(new DateTime(2025, 1, 25, 15, 30, 0), DateTimeKind.Utc) });
                    db.Add(new Screening() { MovieId = 3, Time = DateTime.SpecifyKind(new DateTime(2025, 1, 25, 19, 30, 0), DateTimeKind.Utc) });
                    await db.SaveChangesAsync();
                }

                if (!db.Tickets.Any())
                {
                    db.Add(new Ticket() { CustomerId = 1, SceeringId = 1 });
                    db.Add(new Ticket() { CustomerId = 3, SceeringId = 2 });
                    db.Add(new Ticket() { CustomerId = 1, SceeringId = 3 });
                    db.Add(new Ticket() { CustomerId = 2, SceeringId = 3 });
                    db.Add(new Ticket() { CustomerId = 2, SceeringId = 2 });
                    db.Add(new Ticket() { CustomerId = 3, SceeringId = 1 });
                    await db.SaveChangesAsync();
                }


            }
        }
    }
}
