namespace UnitTestingCourse.Solution.ex4.Refactoring.ex6.Notify
{
    public abstract class StoredItem
    {
        protected Item item;
        public string message;

        public StoredItem(Item item)
        {
            this.item = item;
            message = "";
        }

        public abstract void Update();

        protected void DecreaseSellIn()
        {
            item.SellIn = item.SellIn - 1;
        }

        protected void IncreaseQuality()
        {
            item.Quality = item.Quality + 1;
        }

        protected void DecreaseQuality()
        {
            item.Quality = item.Quality - 1;
        }

        protected void UpdateMessage()
        {
            this.message = String.Format("{0} Updated - Quality: {1}, SellIn: {2}"
                , item.Name, item.Quality, item.SellIn);
        }

    }

    public class DexterityOrElixir : StoredItem
    {
        public DexterityOrElixir(Item item) : base(item) { }

        public override void Update()
        {
            if (item.Quality > 0)
            {
                DecreaseQuality();
            }
            DecreaseSellIn();
            if (item.Quality > 0)
            {
                if (item.SellIn < 0)
                {
                    DecreaseQuality();
                }
            }
            UpdateMessage();
        }
    }

    public class Backstage : StoredItem
    {
        public Backstage(Item item) : base(item) { }

        public override void Update()
        {
            if (item.Quality < 50)
            {
                IncreaseQuality();
                if (item.Quality < 50)
                {
                    if (item.SellIn < 11)
                    {
                        IncreaseQuality();
                    }
                    if (item.SellIn < 6)
                    {
                        IncreaseQuality();
                    }
                }
            }
            DecreaseSellIn();
            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
            UpdateMessage();
        }

    }

    public class AgedBrie : StoredItem
    {
        public AgedBrie(Item item) : base(item) { }

        public override void Update()
        {
            if (item.Quality < 50)
            {
                IncreaseQuality();
            }
            DecreaseSellIn();
            if (item.Quality < 50)
            {
                if (item.SellIn < 0)
                {
                    IncreaseQuality();
                }
            }
            UpdateMessage();
        }
    }

    public class Sulfuras : StoredItem
    {
        public Sulfuras(Item item) : base(item) { }
        public override void Update()
        {
            UpdateMessage();
        }
    }

    public class Conjured : StoredItem
    {
        public Conjured(Item item) : base(item) { }

        public override void Update()
        {
            if (item.Quality > 0)
            {
                DecreaseQuality();
                DecreaseQuality();
            }
            DecreaseSellIn();
            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
            UpdateMessage();
        }
    }


}
