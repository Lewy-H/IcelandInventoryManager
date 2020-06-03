using InventoryManager;
using InventoryManager.Models;
using InventoryManager.Plans;
using System;
using System.Collections.Generic;

namespace InventoryManagerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>()
            {
                new Item{Name = "Aged Brie", SellIn = 1, Quality = 1},
                new Item{Name = "Christmas Crackers", SellIn = -1, Quality = 2},
                new Item{Name = "Christmas Crackers", SellIn = 9, Quality = 2},
                new Item{Name = "Soap", SellIn = 2, Quality = 2},
                new Item{Name = "Frozen Item", SellIn = -1, Quality = 55},
                new Item{Name = "Frozen Item", SellIn = 2, Quality = 2},
                new Item{Name = "INVALID ITEM", SellIn = 2, Quality = 2},
                new Item{Name = "Fresh Item", SellIn = 2, Quality = 2},
                new Item{Name = "Fresh Item", SellIn = -1, Quality = 5},
            };

            List<InventoryItem> inventoryItems = new List<InventoryItem>();

            Console.WriteLine("----- INPUT -----");
            Console.WriteLine("ITEM NAME | SELL IN | QUALITY");
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Name} {item.SellIn} {item.Quality}");
                inventoryItems.Add(ItemUpdateService.ProcessDay(item));
            }

            Console.WriteLine("");
            Console.WriteLine("----- OUTPUT -----");
            Console.WriteLine("ITEM NAME | SELL IN | QUALITY");
            foreach (var item in inventoryItems)
            {
                if (item.ItemValid)
                    Console.WriteLine($"{item.Name} {item.SellIn} {item.Quality}");
                else
                    Console.WriteLine("NO SUCH ITEM");
            }
            Console.ReadKey();
        }
    }
}
