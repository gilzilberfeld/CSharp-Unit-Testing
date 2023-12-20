﻿using ApprovalTests;
using ApprovalTests.Reporters;

namespace UnitTestingCourse.Exercise.ex4.Refactoring
{
    [UseReporter(typeof(VisualStudioReporter))]
    public class GildedRoseTest
    {
        List<Item> items = new List<Item> {
            new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 },
            new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 },
            new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 },
            new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 },
            new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80 },
            new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20 },
            new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 49 },
            new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 49 },
        };

        public string PrintItems()
        {
            string itemLog = "name, sellIn, quality\n";
            foreach (var item in items)
            {
                itemLog += item.ToString();
            }
            itemLog += "\n";

            return itemLog;
        }

        [Test]
        [Ignore("Until necessary")]
        public void GildedRose_FirstUpdate()
        {
            string log = "Before Update\n";
            log += PrintItems();
            new GildedRose(items).UpdateQuality();
            log += "After Update\n";
            log += PrintItems();
            Approvals.Verify(log);
        }
    }
}
