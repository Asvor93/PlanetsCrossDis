using System.Collections.Generic;
using System.Linq;
using Planets.Core.DomainService;
using Planets.Core.Entity;

namespace Planets.Core.ApplicationService.Services
{
    public class OrderService: IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public Order CreateOrder(Order orderToCreate)
        {
            return _orderRepository.CreateOrder(orderToCreate);
        }

        public Order GetSingleOrder(int id)
        {
            return _orderRepository.GetSingleOrder(id);
        }

        public IEnumerable<Order> ReadAllOrders()
        {
            return _orderRepository.ReadAllOrders().ToList();
        }

        public Order UpdateOrder(Order orderToUpdate)
        {
            return _orderRepository.UpdateOrder(orderToUpdate);
        }

        public Order DeleteOrder(Order orderToDelete)
        {
            return _orderRepository.DeleteOrder(orderToDelete.Id);
        }
    }
}