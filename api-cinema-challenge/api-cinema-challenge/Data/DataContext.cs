using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Data
{
    public class DataContext : DbContext
    {
        private string connectionString;
        public DataContext()
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            connectionString = configuration.GetValue<string>("ConnectionStrings:DefaultConnectionString");

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString);

            //set primary of order?

            //seed data?

        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Screening> Screenings { get; set; }

    }
}
