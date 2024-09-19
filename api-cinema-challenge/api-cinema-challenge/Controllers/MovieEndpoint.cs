﻿using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Payload;
using api_cinema_challenge.Repository;
using api_cinema_challenge.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class MovieEndpoint
    {
        public static void ConfigureMovieEndpoint (this WebApplication app)
        {
            var movieGroup = app.MapGroup("/movies");

            movieGroup.MapPost("/", CreateMovie);
            movieGroup.MapGet("/", GetMovies);
            movieGroup.MapPut("/{id}", UpdateMovie);
            movieGroup.MapDelete("/{id}", DeleteMovie);
            movieGroup.MapPost("/{id}/screenings", CreateScreening);
            movieGroup.MapGet("/{id}/screenings", GetScreenings);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateMovie(IMovieRepository repository, IScreeningRepository screeningRepository, MoviePOSTModel model)
        {
            var newMovie = await repository.AddAsync(new Movie() {
                Title = model.Title,
                Rating = model.Rating,
                Description = model.Description,
                RuntimeMins = model.RuntimeMins
            });
            if (model.Screenings != null)
            {
                foreach (var screening in model.Screenings)
                {
                    await screeningRepository.AddAsync(new Screening()
                    {
                        MovieId = newMovie.Id, // Needs to be the int of the newly made movie, I think xD
                        ScreenNumber = screening.ScreenNumber,
                        Capacity = screening.Capacity,
                        StartsAt = screening.StartsAt,
                    });
                }
            }
            MovieDTO responseMovie = (new MovieDTO()
            {
                Id = newMovie.Id,
                Title = newMovie.Title,
                Rating = newMovie.Rating,
                Description = newMovie.Description,
                RuntimeMins = newMovie.RuntimeMins,
                CreatedAt = newMovie.CreatedAt,
                UpdatedAt = newMovie.UpdatedAt,
            });
            Payload<MovieDTO> payload = new Payload<MovieDTO>();
            payload.data = responseMovie;
            payload.status = "success";
            return TypedResults.Created(payload.status, payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetMovies(IMovieRepository repository)
        {
            var found = await repository.GetMovies();
            if (found != null)
            {
                Payload<List<MovieDTO>> payload = new Payload<List<MovieDTO>>();
                payload.data = new List<MovieDTO>();
                foreach (var movie in found)
                {
                    payload.data.Add(new MovieDTO()
                    {
                        Id = movie.Id,
                        Title = movie.Title,
                        Rating = movie.Rating,
                        Description = movie.Description,
                        RuntimeMins = movie.RuntimeMins,
                        CreatedAt = movie.CreatedAt,
                        UpdatedAt = movie.UpdatedAt
                    });
                }
                if (payload.data.Count > 0)
                {
                    payload.status = "success";
                    return TypedResults.Ok(payload);
                }
                else
                {
                    return TypedResults.NotFound("No movies found");
                }
            }
            else
            {
                return TypedResults.NotFound("No movies found");
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> UpdateMovie (IMovieRepository repository, MovieUPDATEModel model, int id)
        {
            var found = await repository.GetMovieById(id);
            if (found != null)
            {
                MovieUPDATEModel innMovie = new MovieUPDATEModel()
                {
                    Title = model.Title,
                    Rating = model.Rating,
                    Description = model.Description,
                    RuntimeMins= model.RuntimeMins
                };
                if (innMovie.Title != "")
                {
                    found.Title = innMovie.Title;
                }
                if (innMovie.Rating != "")
                {
                    found.Rating = innMovie.Rating;
                }
                if (innMovie.Description != "")
                {
                    found.Description = innMovie.Description;
                }
                if (innMovie.RuntimeMins != 0)
                {
                    found.RuntimeMins = innMovie.RuntimeMins;
                }
                await repository.UpdateAsync(found);
                MovieDTO responseMovie = (new MovieDTO()
                {
                    Id = found.Id,
                    Title = found.Title,
                    Rating = found.Rating,
                    Description = found.Description,
                    RuntimeMins = found.RuntimeMins,
                    CreatedAt = found.CreatedAt,
                    UpdatedAt = found.UpdatedAt
                });
                Payload<MovieDTO> payload = new Payload<MovieDTO>();
                payload.data = responseMovie;
                payload.status = "success";
                return TypedResults.Created(payload.status, payload);
            }
            else
            {
                return TypedResults.BadRequest("Could not update movie");
            }
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteMovie(IMovieRepository repository, int id)
        {
            var deletedMovie = await repository.DeleteAsync(id);
            if (deletedMovie != null)
            {
                MovieDTO movie = new MovieDTO()
                {
                    Id = id,
                    Title = deletedMovie.Title,
                    Rating = deletedMovie.Rating,
                    Description = deletedMovie.Description,
                    RuntimeMins = deletedMovie.RuntimeMins,
                    CreatedAt = deletedMovie.CreatedAt,
                    UpdatedAt = deletedMovie.UpdatedAt
                };
                Payload<MovieDTO> payload = new Payload<MovieDTO>();
                payload.data = movie;
                payload.status = "success";
                return TypedResults.Ok(payload);
            }
            else
            {
                return TypedResults.NotFound("Could not delete movie, reason: Not found");
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateScreening (IScreeningRepository repository, IMovieRepository movieRepository, ScreeningPOSTModel model, int id)
        {
            var movieCheck = await movieRepository.GetMovieById(id);
            if (movieCheck != null)
            {
                var newScreening = await repository.AddAsync(new Screening()
                {
                    MovieId = id,
                    ScreenNumber = model.ScreenNumber,
                    Capacity = model.Capacity,
                    StartsAt = model.StartsAt
                });
                ScreeningDTO newScreeningDTO = new ScreeningDTO()
                {
                    MovieTitle = await movieRepository.GetTitleById(id),
                    Id = newScreening.ScreeningId,
                    ScreenNumber = newScreening.ScreenNumber,
                    Capacity = newScreening.Capacity,
                    StartsAt = newScreening.StartsAt,
                    CreatedAt = newScreening.CreatedAt,
                    UpdatedAt = newScreening.UpdatedAt
                };
                Payload<ScreeningDTO> payload = new Payload<ScreeningDTO>();
                payload.data = newScreeningDTO;
                payload.status = "success";
                return TypedResults.Created(payload.status, payload);
            }
            else
            {
                return TypedResults.BadRequest($"Could not schedule screening - reason: No movie with IDnr: {id}");
            }

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetScreenings(IScreeningRepository screeningRepository, IMovieRepository movieRepository, int id)
        {
            var movieCheck = await movieRepository.GetMovieById(id);
            if (movieCheck != null)
            {
                Payload<List<ScreeningDTO>> payload = new Payload<List<ScreeningDTO>>();
                payload.data = new List<ScreeningDTO>();
                var found = await screeningRepository.GetScreenings(id);
                foreach (var screening in found)
                {
                    payload.data.Add (new ScreeningDTO()
                    {
                        MovieTitle = await movieRepository.GetTitleById(id),
                        Id = screening.ScreeningId,
                        ScreenNumber = screening.ScreenNumber,
                        Capacity = screening.Capacity,
                        StartsAt = screening.StartsAt,
                        CreatedAt = screening.CreatedAt,
                        UpdatedAt = screening.UpdatedAt
                    });
                }
                if (payload.data.Count > 0)
                {
                    payload.status = "success";
                    return TypedResults.Ok(payload);
                }
                else
                {
                    return TypedResults.NotFound("No screenings found");
                }
            }
            else
            {
                return TypedResults.NotFound("No screenings found");
            }
        }
    }
}
