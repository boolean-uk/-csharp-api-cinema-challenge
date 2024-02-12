﻿using api_cinema_challenge.Helpers;
using api_cinema_challenge.Models;
using api_cinema_challenge.Models.DTOs;
using api_cinema_challenge.Models.PayLoad;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace api_cinema_challenge.Controllers
{
    public static class CustomerEndpoint
    {
        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            var customers = app.MapGroup("customers");

            customers.MapPost("", PostCustomer);
            customers.MapGet("", GetAllCustomers);
            customers.MapGet("/{id}", GetACustomer);
            customers.MapPut("/{id}", PutCustomer);
            customers.MapDelete("/{id}", DeleteCustomer);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> PostCustomer(IRepository<Customer> repository, CustomerPost model)
        {
            // Map the model to a DTO
            var customerDTO = DTOHelper.MapToDTO<CustomerDTO>(model);

            // Create a payload to return
            var payload = new PayLoad1<CustomerDTO>
            {
                data = customerDTO,
                status = DTOHelper.PropertyChecker<CustomerDTO>(customerDTO)
            };

            // Check if the DTO properties are valid
            if (payload.status == "success")
            {
                // Insert the new customer into the database
                var customer = await repository.Insert(DTOHelper.MapToEntity<Customer>(model, "create"));

                //Give the customerDTO the new customer's id
                payload.data = DTOHelper.MapToDTO<CustomerDTO>(customer);

                // Return the payload
                return TypedResults.Created($"/{payload.data.Id}", payload);
            }
            else
            {
                // Return the payload
                return TypedResults.BadRequest(payload);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetAllCustomers(IRepository<Customer> repository)
        {
            var customers = await repository.SelectAll();
            IEnumerable<CustomerDTO> customerDTOs = customers.Select(c => DTOHelper.MapToDTO<CustomerDTO>(c));

            var payload = new PayLoad1<IEnumerable<CustomerDTO>>
            {
                data = customerDTOs,
                status = customerDTOs.Any() ? "success" : "not found"
            };

            if (payload.status == "success")
            {
                return TypedResults.Ok(payload);
            }
            else
            {
                return TypedResults.NotFound(payload);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetACustomer(IRepository<Customer> repository, int id)
        {
            var customer = await repository.SelectById(id);
            var customerDTO = DTOHelper.MapToDTO<CustomerDTO>(customer);

            var payload = new PayLoad1<CustomerDTO>
            {
                data = customerDTO,
                status = customerDTO != null ? "success" : "not found"
            };

            if (payload.status == "success")
            {
                return TypedResults.Ok(payload);
            }
            else
            {
                return TypedResults.NotFound(payload);
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        //Update an existing movie. If any field is not provided, the original value should not be changed. Any combination of fields can be updated.
        private static async Task<IResult> PutCustomer(IRepository<Customer> repository, int id, CustomerPut model)
        {
            // Fetch the existing customer from the repository
            var existingCustomer = await repository.SelectById(id);
            var payload = new PayLoad1<CustomerDTO>
            {
                data = new CustomerDTO()
            };

            if (existingCustomer == null)
            {
                payload.status = "Customer not found";
                return TypedResults.NotFound(payload);
            }

            // Map the fields from the model to the entity
            var updatedCustomer = DTOHelper.MapToEntity<Customer>(model, "update");

            // Update only the provided fields, keeping the original values if not provided
            if (!string.IsNullOrEmpty(model.Name))
            {
                existingCustomer.Name = updatedCustomer.Name;
            }
            if (!string.IsNullOrEmpty(model.Email))
            {
                existingCustomer.Email = updatedCustomer.Email;
            }
            if (!string.IsNullOrEmpty(model.Phone))
            {
                existingCustomer.Phone = updatedCustomer.Phone;
            }
            // Add conditions for other fields if applicable

            // Update the existing customer in the repository
            var result = await repository.Update(id, existingCustomer);

            // If update successful, return the updated customer
            if (result != null)
            {
                payload.data = DTOHelper.MapToDTO<CustomerDTO>(result);
                return TypedResults.Ok(payload);
            }
            else
            {
                // If update fails, return bad request
                payload.status = "Customer not updated";
                return TypedResults.BadRequest(payload);
            }
        }

        private static async Task<IResult> DeleteCustomer(IRepository<Customer> repository, int id)
        {
            var foundCustomerClass = await repository.Delete(id);
            var payload = new PayLoad1<CustomerDTO>
            {
                data = new CustomerDTO(),
                status = foundCustomerClass != null ? "success" : "Customer not found"
            };

            if (foundCustomerClass == null)
            {
                return TypedResults.NotFound(payload);
            }
            payload.data = DTOHelper.MapToDTO<CustomerDTO>(foundCustomerClass);
            return TypedResults.Ok(payload);
        }
    }
}
