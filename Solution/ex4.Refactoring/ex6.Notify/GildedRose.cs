namespace UnitTestingCourse.Solution.ex4.Refactoring.ex6.Notify
{
    public class GildedRose
    {
        IList<Item> Items;
        private INotificationService notifier;

        public GildedRose(IList<Item> Items, INotificationService notifier)
        {
            this.Items = Items;
            this.notifier = notifier;
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
            notifier.NotifyTownCrier(storedItem.message);
        }

    }
}
