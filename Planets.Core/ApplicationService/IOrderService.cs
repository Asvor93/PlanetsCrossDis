using System.Collections.Generic;
using Planets.Core.Entity;

namespace Planets.Core.ApplicationService
{
    public interface IOrderService
    {
        Order CreateOrder(Order orderToCreate);
        Order GetSingleOrder(int id);
        IEnumerable<Order> ReadAllOrders();
        Order UpdateOrder(Order orderToUpdate);
        Order DeleteOrder(Order orderToDelete);
    }
}