using System;
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
                    db.Add(new Customer() { Name = "Nigel" });
                    db.Add(new Customer() { Name = "Dave" });
                    await db.SaveChangesAsync();
                }
                if (!db.Movies.Any())
                {
                    db.Add(new Movie() { Title = "Cheese & Pineapple" });
                    db.Add(new Movie() { Title = "Vegan Cheese Tastic" });
                    await db.SaveChangesAsync();

                }
                if (!db.Screenings.Any())
                {
                    db.Add(new Screening() { MovieId = 1, StartsAt = DateTime.UtcNow.AddDays(1)});
                    await db.SaveChangesAsync();
                }

                //order data
                if (1 == 1)
                {

                    await db.SaveChangesAsync();
                }
            }
        }
    }
}
