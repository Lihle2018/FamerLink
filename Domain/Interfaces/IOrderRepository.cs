using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IOrderRepository : IRepository<Order>
    {
        IEnumerable<Order> GetByCustomer(Customer customer);
        IEnumerable<Order> GetByVendor(Vendor vendor);
        IEnumerable<Order> GetByStatus(OrderStatus status);
    }
}
