using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface IInventoryManagementService
    {
        bool AddItemToInventory(string itemName, int quantity);
        bool RemoveItemFromInventory(string itemName, int quantity);
        int GetItemStockLevel(string itemName);
    }

}
