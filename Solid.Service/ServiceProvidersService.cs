using Solid.Core.Entities;
using Solid.Core.Repositories;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service
{
    public class ServiceProvidersService : IServiceProvidersService
    {
        private readonly IServiceProvidersRepositories _serviceProvidersRepositories;

        public ServiceProvidersService(IServiceProvidersRepositories serviceProvidersRepositories)
        {
            _serviceProvidersRepositories = serviceProvidersRepositories;
        }

        public IEnumerable<ServiceProviders> GetAllServiceProviders()
        {
            var serviceProviders = _serviceProvidersRepositories.GetServiceProviders();
            return serviceProviders;
        }

        public ServiceProviders GetServiceProviderByID(int id)
        {
            return _serviceProvidersRepositories.GetServiceProvidersById(id);
        }

        public ServiceProviders AddServiceProvider(ServiceProviders newServiceProvider)
        {
            return _serviceProvidersRepositories.AddServiceProviders(newServiceProvider);
        }

        public ServiceProviders UpdateServiceProvider(int id, ServiceProviders newServiceProvider)
        {
            return _serviceProvidersRepositories.UpdateServiceProviders(id, newServiceProvider);
        }

        public void DeleteServiceProviders(int i)
        {
            _serviceProvidersRepositories.DeleteServiceProviders(i);
        }
    }
}
