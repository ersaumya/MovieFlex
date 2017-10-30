using AutoMapper;
using MovieFlex.Dtos;
using MovieFlex.Models;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//using System.Web.Mvc;

namespace MovieFlex.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        //GET/API/Customers
        public IHttpActionResult GetCustomers(string query=null)
        {
            var customerQuery = _context.Customers
                .Include(c => c.MembershipType);
            if (!String.IsNullOrWhiteSpace(query))
                customerQuery = customerQuery.Where(c => c.Name.Contains(query));
            var customerDtos= customerQuery
                .ToList()
                .Select(Mapper.Map<Customer,CustomerDto>);
            return Ok(customerDtos);
        }
        //GET/API/Customers/id
        public IHttpActionResult GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(m => m.Id == id);
            if (customer == null)
                return NotFound();
            return Ok(Mapper.Map<Customer,CustomerDto>(customer));
        }
        //POST/API/Customers
        [HttpPost]
        [Authorize(Roles =RollName.CanManageMovies)]
        public IHttpActionResult CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);
            _context.Customers.Add(customer);
            _context.SaveChanges();
            customerDto.Id = customer.Id;
            return Created(new Uri(Request.RequestUri+"/"+customer.Id),customerDto);
        }
        //Put/Api/Customers/1
        [HttpPut]
        [Authorize(Roles =RollName.CanManageMovies)]
        public IHttpActionResult UpdateCustomer(int id,CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
               
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customerInDb == null)
                return NotFound();
               
            Mapper.Map(customerDto, customerInDb);
           
            _context.SaveChanges();
            return Ok();
        }
        //Delete/Api/Customer/1
        [HttpDelete]
        [Authorize(Roles =RollName.CanManageMovies)]
        public IHttpActionResult RemoveCustomer(int id)
        {
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customerInDb == null)
                return NotFound();
               
            _context.Customers.Remove(customerInDb);
            _context.SaveChanges();
            return Ok();
        }
    }
}
