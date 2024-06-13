using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Solid.Core.Entities;
using Solid.Core.Repositories;

namespace Solid.Data.Repositories
{
    public class CustomerRepositories : ICustomerRepositories
    {
        private readonly DataContaxt _dataContaxt;

        public CustomerRepositories(DataContaxt dataContaxt)
        {
            _dataContaxt = dataContaxt;
        }
        public IEnumerable<Customer> GetCustomers()
        {
            return _dataContaxt.Customers;
            //.Include(c => c.Turns);
        }
        public Customer GetCustomerById(int id)
        {
            return _dataContaxt.Customers.First(c => c.Id == id);
            //.Include(c => c.Turns)
        }

        public Customer AddCustomer(Customer newCustomer)
        {
            _dataContaxt.Customers.Add(newCustomer);
            _dataContaxt.SaveChanges();
            return newCustomer;
        }

        public Customer UpdateCustomer(int i, Customer newCustomer)
        {
            var oldCustomer = GetCustomerById(i);

            oldCustomer.Name = newCustomer.Name;
            oldCustomer.Email = newCustomer.Email;
            oldCustomer.Phone = newCustomer.Phone;

            _dataContaxt.SaveChanges();
            return oldCustomer;
        }

        public void DeleteCustomer(int i)
        {
            var customer = GetCustomerById(i);
            _dataContaxt.Customers.Remove(customer);
            _dataContaxt.SaveChanges();
        }
    }
}
