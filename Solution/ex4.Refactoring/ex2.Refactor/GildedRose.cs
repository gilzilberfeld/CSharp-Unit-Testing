using UnitTestingCourse.Solution.ex4.Refactoring.ex1.AddLogging;

namespace UnitTestingCourse.Solution.ex4.Refactoring.ex2.Refactor
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                UpdateItem(item);
            }
        }
        private void UpdateItem(Item item)
        {
            if (item.Name == "Aged Brie")
            {
                if (item.Quality < 50)
                {
                    IncreaseQuality(item);
                }
                DecreaseSellIn(item);
                if (item.Quality < 50)
                {
                    if (item.SellIn < 0)
                    {
                        IncreaseQuality(item);
                    }
                }
                return;
            }
            if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                if (item.Quality < 50)
                {
                    IncreaseQuality(item);
                    if (item.Quality < 50)
                    {
                        if (item.SellIn < 11)
                        {
                            IncreaseQuality(item);
                        }
                        if (item.SellIn < 6)
                        {
                            IncreaseQuality(item);
                        }
                    }
                }
                DecreaseSellIn(item);
                if (item.SellIn < 0)
                {
                    item.Quality = 0;
                }
                return;
            }
            if (item.Name == "+5 Dexterity Vest" || item.Name == "Elixir of the Mongoose")
            {
                if (item.Quality > 0)
                {
                    DecreaseQuality(item);
                }
                DecreaseSellIn(item);
                if (item.Quality > 0)
                {
                    if (item.SellIn < 0)
                    {
                        DecreaseQuality(item);
                    }
                }
            }
        }

        private void UpdateBackstagePassesAgain(Item item)
        {
            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
        }

        private void UpdateAgedBrieAgain(Item item)
        {
            if (item.Quality < 50)
            {
                if (item.SellIn < 0)
                {
                    IncreaseQuality(item);
                }
            }
        }

        private void UpdateBackstagePasses(Item item)
        {
            if (item.Quality < 50)
            {
                IncreaseQuality(item);
                if (item.Quality < 50)
                {
                    if (item.SellIn < 11)
                    {
                        IncreaseQuality(item);
                    }
                    if (item.SellIn < 6)
                    {
                        IncreaseQuality(item);
                    }
                }
            }
        }

        private void DecreaseSellIn(Item item)
        {
            item.SellIn = item.SellIn - 1;
        }

        private void IncreaseQuality(Item item)
        {
            item.Quality = item.Quality + 1;
        }

        private void DecreaseQuality(Item item)
        {
            item.Quality = item.Quality - 1;
        }
    }

}
