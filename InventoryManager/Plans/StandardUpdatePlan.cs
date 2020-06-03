using InventoryManager.Interfaces;
using InventoryManager.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManager.Plans
{
    public class StandardUpdatePlan : IUpdatePlan
    {
        public void Update(InventoryItem item)
        {
            item.SellIn--;

            int qualityChange = 1;
            if (item.SellIn <= 0)
                qualityChange = qualityChange * 2;

            item.DecreaseQuality(qualityChange);
        }
    }
}
