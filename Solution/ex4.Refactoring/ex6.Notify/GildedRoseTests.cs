using ApprovalTests;
using ApprovalTests.Reporters;

namespace UnitTestingCourse.Solution.ex4.Refactoring.ex6.Notify
{
    [UseReporter(typeof(VisualStudioReporter))]
    public class GildedRoseTest
    {
        //List<Item> items = new List<Item> {
        //    new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 },
        //    new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 },
        //    new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 },
        //    new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 },
        //    new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80 },
        //    new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20 },
        //    new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 49 },
        //    new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 49 },
        //    new Item { Name = "Conjured demon holding vessel", SellIn = 10, Quality = 85 },
        //};

        private List<Item> CreateItemList()
        {
            return new List<Item> {
                new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 },
                new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 },
                new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 },
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 },
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 49 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 49 },
                new Item { Name = "Conjured demon holding vessel", SellIn = 10, Quality = 85 }
            };
        }

        public string PrintItems(List<Item> items)
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
        public void GildedRose_UpdateQuality_30_Days()
        {
            List<Item> items = CreateItemList();

            GildedRose shop = new GildedRose(items, new MockNotifier());
            string log = "";

            for (int day = 0; day < 30; day++)
            {
                log += "Day " + day.ToString() + "\n";
                log += PrintItems(items);
                shop.UpdateQuality();
                log += "\n";
            }
            Approvals.Verify(log);
        }

        [Test]
        public void GildedRose_NotiferMessages_30_Days()
        {
            List<Item> items = CreateItemList();
            MockNotifier notifier = new MockNotifier();
            GildedRose shop = new GildedRose(items, notifier);

            for (int day = 0; day < 30; day++)
            {
                shop.UpdateQuality();
            }
            Approvals.Verify(notifier.notification_log);
        }
    }
}
