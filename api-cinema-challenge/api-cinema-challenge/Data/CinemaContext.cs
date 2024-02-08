﻿using api_cinema_challenge.Models.Domain.Entities.CinemaInfrastructure;
using api_cinema_challenge.Models.Domain.Entities.MoviesAndScreenings;
using api_cinema_challenge.Models.Domain.Entities.SalesAndTickets;
using api_cinema_challenge.Models.Domain.Junctions;
using Microsoft.EntityFrameworkCore;
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
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TicketSeat>().HasKey(ts => new { ts.SeatId, ts.ScreeningId });
            modelBuilder.Entity<Movie>().Property(m => m.Rating).HasConversion<string>();
            modelBuilder.SeedDatabase();
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Auditorium> Auditoriums { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketSeat> TicketSeats { get; set; }
    }
}
