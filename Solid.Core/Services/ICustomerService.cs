using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
   public interface ICustomerService
    {
        IEnumerable<Customer> GetAllCustomer();

        Customer GetCustomerByID(int id);

        Customer AddCustomer(Customer newCustomer);

        Customer UpdateCustomer(int id, Customer newCustomer);

        void DeleteCustomer(int i);

    }
}
