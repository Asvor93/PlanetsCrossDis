using System.Collections.Generic;
using System.Linq;
using Planets.Core.DomainService;
using Planets.Core.Entity;

namespace Planets.Core.ApplicationService.Services
{
    public class CustomerService: ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public Customer CreateCustomer(Customer customerToCreate)
        {
            return _customerRepository.CreateCustomer(customerToCreate);
        }

        public IEnumerable<Customer> ReadCustomers()
        {
            return _customerRepository.ReadCustomers().ToList();
        }

        public Customer GetSingleCustomer(int id)
        {
            return _customerRepository.GetSingleCustomer(id);
        }

        public Customer UpdateCustomer(Customer customerToUpdate)
        {
            return _customerRepository.UpdateCustomer(customerToUpdate);
        }

        public Customer DeleteCustomer(Customer customerToDelete)
        {
            return _customerRepository.DeleteCustomer(customerToDelete.Id);
        }
    }
}