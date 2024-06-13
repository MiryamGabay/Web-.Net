using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IServiceProvidersService
    {
        IEnumerable<ServiceProviders> GetAllServiceProviders();

        ServiceProviders GetServiceProviderByID(int id);

        ServiceProviders AddServiceProvider(ServiceProviders newServiceProviders);

        ServiceProviders UpdateServiceProvider(int id, ServiceProviders newServiceProviders);

        void DeleteServiceProviders(int i);
    }
}
