using api_cinema_challenge.DTO.CustomerDTO;
using api_cinema_challenge.DTO.MovieDTO;
using api_cinema_challenge.DTO.ScreeningDTO;
using api_cinema_challenge.DTO.TicketDTO;
using api_cinema_challenge.Models;
using api_cinema_challenge;
using AutoMapper;

namespace exercise.cinemaapi.Tools
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Customer, CustomersDTO>()
                .ForMember(dest => dest.Tickets, opt => opt.MapFrom(src => src.Tickets))
                .ReverseMap();

            CreateMap<Movie, MoviesDTO>()
                .ForMember(dest => dest.Screenings, opt => opt.MapFrom(src => src.Screenings))
                .ReverseMap();

            CreateMap<Screening, ScreeningsDTO>()
                .ForMember(dest => dest.Movie, opt => opt.MapFrom(src => src.Movie))
                .ReverseMap();

            CreateMap<Ticket, TicketsDTO>()
                .ForMember(dest => dest.Customer, opt => opt.MapFrom(src => src.Customer))
                .ForMember(dest => dest.Screening, opt => opt.MapFrom(src => src.Screening))
                .ReverseMap();
            CreateMap<Screening, ScreeningNoMovieDTO>().ReverseMap();
            CreateMap<Customer, CustomerNoTicketDTO>().ReverseMap();
            CreateMap<Customer, CreateCustomerDTO>().ReverseMap();
            CreateMap<Screening, CreateScreeningDTO>().ReverseMap();
            CreateMap<Movie, CreateMovieDTO>().ReverseMap();
            CreateMap<Ticket, CreateTicketDTO>().ReverseMap();
        }
    }
}
