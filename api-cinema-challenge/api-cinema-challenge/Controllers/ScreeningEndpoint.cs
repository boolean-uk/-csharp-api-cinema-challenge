﻿using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class ScreeningEndpoint
    {
        public static void ConfigureScreeningEndpoint(this WebApplication app)
        {
            var screening = app.MapGroup("screenings");
            screening.MapPost("/", AddScreening);
            screening.MapGet("/", GetScreening);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> AddScreening(IRepository repository, int screenNumber, int capacity, DateTime startsAt)
        {
            try
            {
                var screening = await repository.AddScreening(screenNumber, capacity, startsAt);
                var dto = DTOConvert.DTOConvertObject(screening);
                return screening != null ? TypedResults.Ok(new Payload<DTOScreeningObject> { data = dto }) : TypedResults.NotFound("NotFound");

            }
            catch (Exception ex)
            {
                using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
                ILogger logger = factory.CreateLogger("Errors");
                logger.LogInformation(ex.ToString());

                return TypedResults.BadRequest("Bad Request");
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetScreening(IRepository repository)
        {
            try
            {
                var screening = await repository.GetScreening();
                var dto = DTOConvert.DTOConvertList(screening);
                return screening != null ? TypedResults.Ok(new Payload<IEnumerable<DTOScreeningObject>> { data = dto }) : TypedResults.NotFound("NotFound");
            }
            catch (Exception ex)
            {
                using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
                ILogger logger = factory.CreateLogger("Errors");
                logger.LogInformation(ex.ToString());

                return TypedResults.BadRequest("Bad Request");
            }
        }
    }
}
