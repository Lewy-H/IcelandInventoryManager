using InventoryManager.Interfaces;

namespace InventoryManager.Plans
{
    public class ChristmasCrackerUpdatePlan : IUpdatePlan
    {
        public void Update(InventoryItem item)
        {
            item.SellIn--;

            //Assumes sell by date is set to Christmas day
            if (item.SellIn < 0)
            {
                item.Quality = 0;
                return;
            }

            int qualityChange;

            if (item.SellIn <= 5)
                qualityChange = 3;
            else if (item.SellIn <= 10)
                qualityChange = 2;
            else
                qualityChange = 1;

            item.IncreaseQuality(qualityChange);
        }
    }
}
