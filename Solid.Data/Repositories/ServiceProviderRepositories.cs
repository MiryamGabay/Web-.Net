using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Solid.Data.Repositories
{
    public class ServiceProviderRepositories : IServiceProvidersRepositories
    {
        private readonly DataContaxt _dataContaxt;

        public ServiceProviderRepositories(DataContaxt dataContaxt)
        {
            _dataContaxt = dataContaxt;
        }
        public IEnumerable<ServiceProviders> GetServiceProviders()
        {
            return _dataContaxt.Services;
            //.Include(s => s.Turns);
        }
        public ServiceProviders GetServiceProvidersById(int id)
        {
            return _dataContaxt.Services.First(s => s.Id == id);
            //.Include(s => s.Turns)
        }
        public ServiceProviders AddServiceProviders(ServiceProviders newServiceProviders)
        {
            _dataContaxt.Services.Add(newServiceProviders);
            _dataContaxt.SaveChanges();
            return newServiceProviders;
        }
        public ServiceProviders UpdateServiceProviders(int i, ServiceProviders newServiceProviders)
        {
            var oldServiceProviders = GetServiceProvidersById(i);

            oldServiceProviders.Name = newServiceProviders.Name;
            oldServiceProviders.Email = newServiceProviders.Email;
            oldServiceProviders.Phone = newServiceProviders.Phone;
            oldServiceProviders.DayWork = newServiceProviders.DayWork;
            oldServiceProviders.Start = newServiceProviders.Start;
            oldServiceProviders.End = newServiceProviders.End;

            _dataContaxt.SaveChanges();
            return oldServiceProviders;
        }
        public void DeleteServiceProviders(int i)
        {
            var serviceProviders = GetServiceProvidersById(i);

            _dataContaxt.Services.Remove(serviceProviders);
            _dataContaxt.SaveChanges();
        }
    }
}
