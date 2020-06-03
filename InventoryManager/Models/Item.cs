using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManager.Models
{    
    public class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }
    }
}
