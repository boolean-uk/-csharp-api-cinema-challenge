﻿using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class CustomerEndpoint
    {
        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            var customers = app.MapGroup("customers");
            customers.MapPost("/", AddCustomer);
            customers.MapGet("/", GetCustomers);
            customers.MapPut("/{id}", UppdateCustomer);
            customers.MapDelete("/{id}", DeleteCustomer);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> AddCustomer(IRepository repository, string name, string email, string phonenumber)
        {
            try
            {
                var customer = await repository.AddCustomer(name, email, phonenumber);
                var dto = DTOConvert.DTOConvertObject(customer);
                return customer != null ? TypedResults.Ok(new Payload<DTOCustomerObject> { data = dto}) : TypedResults.NotFound();
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
         private static async Task<IResult> GetCustomers(IRepository repository)
        {
            try
            {
                var customers = await repository.GetCustomers();
                var dtos = DTOConvert.DTOConvertList(customers);
                return customers != null ? TypedResults.Ok(new Payload<IEnumerable<DTOCustomerObject>> { data = dtos}) : TypedResults.NotFound("NotFound");
            }
            catch (Exception ex)
            {
                using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
                ILogger logger = factory.CreateLogger("Errors");
                logger.LogInformation(ex.ToString());

                return TypedResults.BadRequest("Bad Request");
            }
}

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> UppdateCustomer(IRepository repository, int id, string? name, string? email, string? phone)
        {
            try
            {
                var customer = await repository.UppdateCustomer(id,name, email, phone);
                var dto = DTOConvert.DTOConvertObject(customer);
                return customer != null ? TypedResults.Ok(new Payload<DTOCustomerObject> { data = dto }) : TypedResults.NotFound("NotFound");
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
        private static async Task<IResult> DeleteCustomer(IRepository repository, int id)
        {
            try
            {
                var customer = await repository.DeleteCustomer(id);
                var dto = DTOConvert.DTOConvertObject(customer);
                return customer != null ? TypedResults.Ok(new Payload<DTOCustomerObject> { data = dto }) : TypedResults.NotFound("NotFound");
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
