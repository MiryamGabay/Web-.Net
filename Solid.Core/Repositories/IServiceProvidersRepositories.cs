using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Core.Entities;

namespace Solid.Core.Repositories
{
    public interface IServiceProvidersRepositories
    {
        IEnumerable<ServiceProviders> GetServiceProviders();
        ServiceProviders GetServiceProvidersById(int id);
        ServiceProviders AddServiceProviders(ServiceProviders newServiceProviders);
        ServiceProviders UpdateServiceProviders(int i, ServiceProviders newServiceProviders);
        void DeleteServiceProviders(int i);
    }
}
