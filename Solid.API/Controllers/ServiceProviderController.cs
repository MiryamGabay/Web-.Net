using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Solid.API.Entites;
using Solid.Core.DTOs;
using Solid.Core.Entities;
using Solid.Core.Services;
using Solid.Service;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("QueenBride/[controller]")]
    [ApiController]
    public class ServiceProviderController : ControllerBase
    {
        private readonly IServiceProvidersService _serviceProviderIsService;
        private readonly IMapper _mapper;

        public ServiceProviderController(IServiceProvidersService serviceProviderIsService,IMapper mapper)
        {
            _serviceProviderIsService = serviceProviderIsService;
            _mapper = mapper;
        }
        // GET: api/<ServiceProviderController>
        [HttpGet]
        public ActionResult Get()
        {
            var services = _serviceProviderIsService.GetAllServiceProviders();
            var servicesDto = _mapper.Map<List<ServiceProvidersDto>>(services);
            return Ok(servicesDto);
        }

        // GET api/<ServiceProviderController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var service = _serviceProviderIsService.GetAllServiceProviders();
            var serviceDto = _mapper.Map<ServiceProvidersDto>(service);
            return Ok(serviceDto);
        }

        // POST api/<ServiceProviderController>
        [HttpPost]
        public ActionResult Post([FromBody] ServiceProvidersPostEntite newServiceProvider)
        {
            var serviceProvider = new ServiceProviders
            {
                Name = newServiceProvider.Name,
                Email = newServiceProvider.Email,
                Phone = newServiceProvider.Phone,
                DayWork = newServiceProvider.DayWork,
                Start = newServiceProvider.Start,
                End = newServiceProvider.End
            };
            var service = _serviceProviderIsService.AddServiceProvider(serviceProvider);
            var serviceDto = _mapper.Map<ServiceProvidersDto>(service);
            return Ok(serviceDto);
        }

        // PUT api/<ServiceProviderController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ServiceProvidersPostEntite newServiceProvider)
        {
            var serviceProvider = new ServiceProviders
            {
                Name = newServiceProvider.Name,
                Email = newServiceProvider.Email,
                Phone = newServiceProvider.Phone,
                DayWork = newServiceProvider.DayWork,
                Start = newServiceProvider.Start,
                End = newServiceProvider.End
            };
            var service = _serviceProviderIsService.UpdateServiceProvider(id, serviceProvider);
            var serviceDto = _mapper.Map<ServiceProvidersDto>(service);
            return Ok(serviceDto);
        }

        // DELETE api/<ServiceProviderController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            ServiceProviders serviceProviders = _serviceProviderIsService.GetServiceProviderByID(id);
            if (serviceProviders is null)
                return NotFound();
            _serviceProviderIsService.DeleteServiceProviders(id);
            return NoContent();
        }
    }
}
