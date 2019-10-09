using System.Collections.Generic;
using Planets.Core.Entity;

namespace Planets.Core.DomainService
{
    public interface IOrderRepository
    {
        Order CreateOrder(Order orderToCreate);
        Order GetSingleOrder(int id);
        IEnumerable<Order> ReadAllOrders();
        Order UpdateOrder(Order orderToUpdate);
        Order DeleteOrder(int id);

    }
}