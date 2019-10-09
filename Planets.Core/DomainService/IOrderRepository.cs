using Planets.Core.Entity;

namespace Planets.Core.DomainService
{
    public interface IOrderRepository
    {
        Order CreateOrder(Order orderToCreate);
        Order GetSingleOrder(int id);
        Order ReadAllOrders();
        Order UpdateOrder(Order orderToUpdate);
        Order DeleteOrder(Order orderToDelete);

    }
}