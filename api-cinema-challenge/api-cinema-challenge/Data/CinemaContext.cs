using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop.Infrastructure;
using Newtonsoft.Json.Linq;

namespace api_cinema_challenge.Data
{
    public class CinemaContext : DbContext
    {
        private string _connectionString;
        public CinemaContext(DbContextOptions<CinemaContext> options) : base(options)
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            _connectionString = configuration.GetValue<string>("ConnectionStrings:DefaultConnectionString")!;
            this.Database.SetConnectionString(_connectionString);
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
            //optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //keys
            modelBuilder.Entity<Customer>()
                .HasKey(a => a.customerId);

            modelBuilder.Entity<Movie>()
                .HasKey(a => a.movieId);

            modelBuilder.Entity<Screen>()
                .HasKey(a => a.screenId);

            modelBuilder.Entity<Ticket>()
                .HasKey(a => a.ticketId);
            modelBuilder.Entity<MovieOnScreen>()
                .HasKey(a => new {a.movieId, a.screenId});

            //defining relations
            modelBuilder.Entity<Customer>()
                .HasMany(a => a.tickets)
                .WithOne(a => a.customer);

            modelBuilder.Entity<Ticket>()
                .HasOne(a => a.customer)
                .WithMany(a => a.tickets)
                .HasForeignKey(a => a.customerID);
            modelBuilder.Entity<Ticket>()
                .HasOne(a => a.screen)
                .WithMany(a => a.tickets);
    

            modelBuilder.Entity<Screen>()
                .HasMany(a => a.tickets)
                .WithOne(a => a.screen)
                .HasForeignKey(a => a.ticketId);

            modelBuilder.Entity<Screen>()
                .HasMany(a => a.moviesOnScreen)
                .WithOne(a => a.screen);

            modelBuilder.Entity<MovieOnScreen>()
                .HasOne(a => a.screen)
                .WithMany(a => a.moviesOnScreen)
                .HasForeignKey(a => a.screenId);

            modelBuilder.Entity<MovieOnScreen>()
                .HasOne(a => a.movie)
                .WithMany(a => a.moviesOnScreens)
                .HasForeignKey(a => a.movieId);

            modelBuilder.Entity<Movie>()
                .HasMany(a => a.moviesOnScreens)
                .WithOne(a => a.movie);

            //seeding
            modelBuilder.Entity<Movie>()
                .HasData(
                new List<Movie>
                {
                    new Movie { movieId=1 ,Title = "the hobbit", CreatedAt =DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc) ,Rating = "10",Description= "a lonely hobbit travels the world together with his trusty friends gollum and sauron", RuntimeMins="120"}
                }
                );
            modelBuilder.Entity<Customer>()
                .HasData(
                    new List<Customer>
                    {
                        new Customer {customerId =1, Name="bob" , CreatedAt = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc), Email="bob@gmail.com", Phone="12345678" , UpdatedAt=DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc)}
                    }
                );
            modelBuilder.Entity<Screen>()
                .HasData(
                    new List<Screen>
                    {
                        new Screen {screenId=1, capacity=2, createdAt= DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc), screenNumber=1, startsAt=DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc), updatedAt= DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc)}
                    }
                );
            modelBuilder.Entity<Ticket>()
                .HasData(
                    new List<Ticket>
                    {
                        new Ticket {ticketId=1, customerID=1}
                    }
                    );
            modelBuilder.Entity<MovieOnScreen>()
                .HasData(
                    new List<MovieOnScreen>
                    {
                        new MovieOnScreen { movieId=1, screenId=1}
                    }
                    );
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Screen > Screens { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<MovieOnScreen> movieOnScreens { get; set; }
    }
}
