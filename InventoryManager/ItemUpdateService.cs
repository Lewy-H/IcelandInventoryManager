using InventoryManager.Models;
using System.Collections.Generic;

namespace InventoryManager
{
    public static class ItemUpdateService
    {
        public static InventoryItem ProcessDay(Item item)
        {
            var inventoryItem = new InventoryItem(item);
            inventoryItem.ProcessDay();
            return inventoryItem;
        }
    }
}
