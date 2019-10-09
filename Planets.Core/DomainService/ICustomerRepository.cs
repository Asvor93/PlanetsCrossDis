using System.Collections.Generic;
using Planets.Core.Entity;

namespace Planets.Core.DomainService
{
    public interface ICustomerRepository
    {
        Customer CreateCustomer(Customer customerToCreate);
        IEnumerable<Customer> ReadCustomers();
        Customer GetSingleCustomer(int id);
        Customer UpdateCustomer(Customer customerToUpdate);
        Customer DeleteCustomer(int id);
    }
}