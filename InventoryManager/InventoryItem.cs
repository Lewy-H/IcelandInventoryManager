using InventoryManager.Interfaces;
using InventoryManager.Models;
using InventoryManager.Plans;
using System;

namespace InventoryManager
{
    public class InventoryItem
    {
        private readonly Item _item;
        private readonly IUpdatePlan _updateQualityPlan;
        public InventoryItem(Item item)
        {
            this._item = item;
            ItemValid = true;

            if (Name == "Aged Brie")
            {
                _updateQualityPlan = new AgedBrieUpdatePlan();
            }
            else if (Name == "Christmas Crackers")
            {
                _updateQualityPlan = new ChristmasCrackerUpdatePlan();
            }
            else if (Name == "Soap")
            {
                _updateQualityPlan = new SoapUpdatePlan();
            }
            else if (Name == "Fresh Item")
            {
                _updateQualityPlan = new FreshItemUpdatePlan();
            }
            else if (Name == "Frozen Item")
            {
                _updateQualityPlan = new StandardUpdatePlan();
            }
            else
            {
                ItemValid = false;
            }
        }
        public string Name
        {
            get { return _item.Name; }
            set { _item.Name = value; }
        }

        public int SellIn
        {
            get { return _item.SellIn; }
            set { _item.SellIn = value; }
        }

        public int Quality
        {
            get { return _item.Quality; }
            set { _item.Quality = value; }
        }

        public bool ItemValid { get; set; }

        public void IncreaseQuality(int value = 1)
        {
            Quality = Quality + value;
            if (Quality > 50)
                Quality = 50;
            else if (Quality < 0)
                Quality = 0;
        }

        public void DecreaseQuality(int value = 1)
        {
            Quality = Quality - value;
            if (Quality < 0)
                Quality = 0;
            else if (Quality > 50)
                Quality = 50;
        }

        public void ProcessDay()
        {
            if (ItemValid)
                _updateQualityPlan.Update(this);
        }
    }
}
