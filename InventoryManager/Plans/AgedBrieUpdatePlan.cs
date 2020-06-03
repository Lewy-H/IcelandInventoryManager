using InventoryManager.Interfaces;

namespace InventoryManager.Plans
{
    public class AgedBrieUpdatePlan : IUpdatePlan
    {
        public void Update(InventoryItem item)
        {
            item.SellIn--;
            item.IncreaseQuality(1);
        }
    }
}
