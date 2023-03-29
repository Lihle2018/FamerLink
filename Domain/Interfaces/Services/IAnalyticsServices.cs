using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface IAnalyticsService
    {
        int GetTotalOrders();
        int GetTotalCustomers();
        decimal GetTotalSales();
        Dictionary<string, int> GetTopSellingProducts(int limit);
    }
}
