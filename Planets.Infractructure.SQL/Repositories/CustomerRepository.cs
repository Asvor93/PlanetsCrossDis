using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Planets.Core.DomainService;
using Planets.Core.Entity;

namespace Planets.Infrastructure.SQL.Repositories
{
    public class CustomerRepository: ICustomerRepository
    {
        private PlanetsCrossDisContext _context;

        public CustomerRepository(PlanetsCrossDisContext context)
        {
            _context = context;
        }
        public Customer CreateCustomer(Customer customerToCreate)
        {
            _context.Attach(customerToCreate).State = EntityState.Added;
            _context.SaveChanges();
            return customerToCreate;
        }

        public IEnumerable<Customer> ReadCustomers()
        {
            return _context.Customers;
        }

        public Customer GetSingleCustomer(int id)
        {
            return _context.Customers.FirstOrDefault(c => c.Id == id);
        }

        public Customer UpdateCustomer(Customer customerToUpdate)
        {
            _context.Attach(customerToUpdate).State = EntityState.Modified;
            _context.SaveChanges();
            return customerToUpdate;
        }

        public Customer DeleteCustomer(int id)
        {
            var customerToRemove = _context.Customers.Remove(new Customer {Id = id}).Entity;
            _context.SaveChanges();
            return customerToRemove;
        }
    }
}