using AutoMapper;
//using Google.Api.Ads.AdWords.v201809;
using Microsoft.AspNetCore.Mvc;
using Solid.API.Entites;
using Solid.Core;
using Solid.Core.DTOs;
using Solid.Core.Entities;
using Solid.Core.Services;
using Solid.Service;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("QueenBride/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;

        public CustomersController(ICustomerService customerService, IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }

        // GET: api/<CustomersController>
        [HttpGet]
        public ActionResult Get()
        {
            var customersList = _customerService.GetAllCustomer();
            var customersDto = _mapper.Map<List<CustomerDto>>(customersList);
            return Ok(customersDto);
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var customer = _customerService.GetCustomerByID(id);
            var customesDto = _mapper.Map<CustomerDto>(customer);
            return Ok(customesDto);
        }

        // POST api/<CustomersController>
        [HttpPost]
        public ActionResult Post([FromBody] CustomerPostEntite newCustomer)
        {
            var customer = new Customer
            {
                Name = newCustomer.Name,
                Email = newCustomer.Email,
                Phone = newCustomer.Phone
            };
            var afterAdd = _customerService.AddCustomer(customer);
            var afterAddDto = _mapper.Map<CustomerDto>(afterAdd);
            return Ok(afterAddDto);
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] CustomerPostEntite newCustomer)
        {
            var customer = new Customer
            {
                Name = newCustomer.Name,
                Email = newCustomer.Email,
                Phone = newCustomer.Phone
            };
            return Ok(_customerService.UpdateCustomer(id, customer));
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var customer = _customerService.GetCustomerByID(id);
            if(customer is null)
              return NotFound();
            _customerService.DeleteCustomer(id);
            return NoContent();
        }
    }
}
