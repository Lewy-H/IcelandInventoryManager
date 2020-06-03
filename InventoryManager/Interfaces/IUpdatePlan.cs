using InventoryManager.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManager.Interfaces
{
    interface IUpdatePlan
    {
        void Update(InventoryItem item);
    }
}
