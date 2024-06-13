using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Core.Services;
using System.Net.Http.Headers;

namespace Solid.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepositories _customerServiceRepositories;

        public CustomerService(ICustomerRepositories customerRepositories)
        {
            _customerServiceRepositories = customerRepositories;
        }

        public IEnumerable<Customer> GetAllCustomer()
        {
            var customers = _customerServiceRepositories.GetCustomers();
            return customers;
        }

        public Customer GetCustomerByID(int id)
        {
            return _customerServiceRepositories.GetCustomerById(id);
        }

        public Customer AddCustomer(Customer newCustomer)
        {
            return _customerServiceRepositories.AddCustomer(newCustomer);
        }

        public Customer UpdateCustomer(int id, Customer newCustomer)
        {
            return _customerServiceRepositories.UpdateCustomer(id, newCustomer);
        }

        public void DeleteCustomer(int i)
        {
            _customerServiceRepositories.DeleteCustomer(i);
        }


    }
}
