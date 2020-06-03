using InventoryManager.Interfaces;

namespace InventoryManager.Plans
{
    public class SoapUpdatePlan : IUpdatePlan
    {
        public void Update(InventoryItem item)
        {
            //Soap is immutable
        }
    }
}
