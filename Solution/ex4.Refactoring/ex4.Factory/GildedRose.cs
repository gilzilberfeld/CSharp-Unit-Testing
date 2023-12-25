namespace UnitTestingCourse.Solution.ex4.Refactoring.ex4.Factory
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
            var storedItem = ItemFactory.GetItemByName(item);
            storedItem.Update();
        }
    }
}
