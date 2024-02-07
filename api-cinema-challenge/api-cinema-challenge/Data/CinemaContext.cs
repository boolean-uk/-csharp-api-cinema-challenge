﻿using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Newtonsoft.Json.Linq;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Data
{
    public class CinemaContext : DbContext
    {
        public CinemaContext(DbContextOptions<CinemaContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Seeder seeder = new Seeder();

            modelBuilder.Entity<ScreeningTicket>().HasKey(k => new { k.TicketId, k.ScreeningId });
            modelBuilder.Entity<CustomerTicket>().HasKey(k => new { k.CustomerId, k.TicketId });
            modelBuilder.Entity<Movie>()
                .HasMany(m => m.Screenings)
                .WithOne(s => s.Movie)
                .HasForeignKey(s => s.MovieId);

            modelBuilder.Entity<Movie>().HasData(seeder.Movies);
            modelBuilder.Entity<Screening>()
                .HasData(seeder.Screenings);
            modelBuilder.Entity<Customer>().HasData(seeder.Customers);

            modelBuilder.Entity<Ticket>().HasData(seeder.Tickets);

            modelBuilder.Entity<CustomerTicket>().HasData(seeder.CustomerTickets);

            modelBuilder.Entity<ScreeningTicket>().HasData(seeder.ScreeningTickets);

        }

        public DbSet<Ticket> Tickets {get; set;}
        public DbSet<Customer> Customers {get; set;}
        public DbSet<Movie> Movies {get; set;}
        public DbSet<Screening> Screenings {get; set;}
        public DbSet<CustomerTicket> CustomerTickets {get; set;}
        public DbSet<ScreeningTicket> ScreeningTickets {get; set;}

    }
}
