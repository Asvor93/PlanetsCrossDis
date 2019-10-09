using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Planets.Core.DomainService;
using Planets.Core.Entity;

namespace Planets.Infrastructure.SQL.Repositories
{
    public class OrderRepository: IOrderRepository
    {
        readonly PlanetsCrossDisContext _context;

        public OrderRepository(PlanetsCrossDisContext context)
        {
            _context = context;
        }
        public Order CreateOrder(Order orderToCreate)
        {
            _context.Attach(orderToCreate).State = EntityState.Added;
            _context.SaveChanges();
            return orderToCreate;

        }

        public Order GetSingleOrder(int id)
        {
            return _context.Orders.FirstOrDefault(o => o.Id == id);
        }

        public IEnumerable<Order> ReadAllOrders()
        {
            return _context.Orders;
        }

        public Order UpdateOrder(Order orderToUpdate)
        {
            _context.Attach(orderToUpdate).State = EntityState.Modified;
            _context.SaveChanges();
            return orderToUpdate;
        }

        public Order DeleteOrder(int id)
        {
            var orderToRemove = _context.Remove(new Order {Id = id}).Entity;
            _context.SaveChanges();
            return orderToRemove;
        }
    }
}