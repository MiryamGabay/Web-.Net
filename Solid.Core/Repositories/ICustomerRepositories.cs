using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Core.Entities;

namespace Solid.Core.Repositories
{
    public interface ICustomerRepositories
    {
        IEnumerable<Customer> GetCustomers();
        Customer GetCustomerById(int id);
        Customer AddCustomer(Customer newCustomer);
        Customer UpdateCustomer(int i, Customer newCustomer);
        void DeleteCustomer(int i);
    }
}
