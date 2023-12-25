namespace UnitTestingCourse.Solution.ex4.Refactoring.ex4.Factory
{
    internal class ItemFactory
    {
        public static StoredItem GetItemByName(Item item)
        {
            switch (item.Name)
            {
                case "Aged Brie":
                    return new AgedBrie(item);
                case "Backstage passes to a TAFKAL80ETC concert":
                    return new Backstage(item);
                case "+5 Dexterity Vest":
                case "Elixir of the Mongoose":
                    return new DexterityOrElixir(item);
                case "Sulfuras, Hand of Ragnaros":
                    return new Sulfuras(item);
                default:
                    return null;
            }
        }
    }
}
