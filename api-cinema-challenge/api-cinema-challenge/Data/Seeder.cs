﻿using api_cinema_challenge.Models.DatabaseModels;

namespace api_cinema_challenge.Data
{
    public class Seeder
    {
        public List<Customer> Customers = new List<Customer>()
        {
            new Customer() {Id = 1, Name = "Barack Obama", Email = "barack@obama.com", Phone = "+4712345678"},
            new Customer() {Id = 2, Name = "Donald Trump", Email = "donald@trump.com", Phone = "+4787654321"},
            new Customer() {Id = 3, Name = "Joe Biden", Email = "joe@biden.com", Phone = "+4712348765"}
        };

        public List<Movie> Movies = new List<Movie>()
        {
            new Movie() {Id = 1, Title = "Oppenheimer", Rating = "R", RuntimMins = 180},
            new Movie() {Id = 2, Title = "There Will Be Blood", Rating = "12A", RuntimMins = 158},
            new Movie() {Id = 3, Title = "The Lord of the Rings: The Return of the King", Rating = "12A", RuntimMins = 201}
        };

        public List<Screen> Screens = new List<Screen>()
        {
            new Screen() {Id = 1, ScreenNumber = 1, Capacity = 120, MovieId = 1},
            new Screen() {Id = 2, ScreenNumber = 2, Capacity = 80, MovieId = 2 },
            new Screen() {Id = 3, ScreenNumber = 3, Capacity = 98, MovieId = 3 }
        };

        public List<CustomerScreening> CustomerScreenings = new List<CustomerScreening>()
        {
            new CustomerScreening(){CustomerId = 1, ScreeningId = 1},
            new CustomerScreening(){CustomerId = 2, ScreeningId = 2},
            new CustomerScreening(){CustomerId = 3, ScreeningId = 3}
        };
    }
}
