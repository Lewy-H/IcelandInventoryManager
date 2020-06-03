using InventoryManager.Interfaces;

namespace InventoryManager.Plans
{
    public class FreshItemUpdatePlan : IUpdatePlan
    {
        public void Update(InventoryItem item)
        {
            item.SellIn--;
            int qualityChange = 2;
            if (item.SellIn <= 0)
                qualityChange = qualityChange * 2;

            item.DecreaseQuality(qualityChange);
        }
    }
}
