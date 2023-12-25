namespace UnitTestingCourse.Solution.ex4.Refactoring.ex3.StoredItem
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
            switch (item.Name)
            {
                case "Aged Brie":
                    new AgedBrie(item).Update();
                    break;
                case "Backstage passes to a TAFKAL80ETC concert":
                    new Backstage(item).Update();
                    break;
                case "+5 Dexterity Vest":
                case "Elixir of the Mongoose":
                    new DexterityOrElixir(item).Update();
                    break;
            }
        }
    }
}
