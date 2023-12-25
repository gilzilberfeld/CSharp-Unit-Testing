namespace UnitTestingCourse.Solution.ex4.Refactoring.ex4.Factory
{
    public abstract class StoredItem
    {
        protected Item item;
        protected string message;

        public StoredItem(Item item)
        {
            this.item = item;
            this.message = "";
        }

        public abstract void Update();

        protected void DecreaseSellIn()
        {
            this.item.SellIn = this.item.SellIn - 1;
        }

        protected void IncreaseQuality()
        {
            this.item.Quality = this.item.Quality + 1;
        }

        protected void DecreaseQuality()
        {
            this.item.Quality = this.item.Quality - 1;
        }
    }

    public class DexterityOrElixir : StoredItem
    {
        public DexterityOrElixir(Item item) : base(item) { }

        public override void Update()
        {
            if (this.item.Quality > 0)
            {
                this.DecreaseQuality();
            }
            this.DecreaseSellIn();
            if (this.item.Quality > 0)
            {
                if (this.item.SellIn < 0)
                {
                    this.DecreaseQuality();
                }
            }
        }
    }

    public class Backstage : StoredItem
    {
        public Backstage(Item item) : base(item) { }

        public override void Update()
        {
            if (this.item.Quality < 50)
            {
                this.IncreaseQuality();
                if (this.item.Quality < 50)
                {
                    if (this.item.SellIn < 11)
                    {
                        this.IncreaseQuality();
                    }
                    if (this.item.SellIn < 6)
                    {
                        this.IncreaseQuality();
                    }
                }
            }
            this.DecreaseSellIn();
            if (this.item.SellIn < 0)
            {
                this.item.Quality = 0;
            }
        }
    }

    public class AgedBrie : StoredItem
    {
        public AgedBrie(Item item) : base(item) { }

        public override void Update()
        {
            if (this.item.Quality < 50)
            {
                this.IncreaseQuality();
            }
            this.DecreaseSellIn();
            if (this.item.Quality < 50)
            {
                if (this.item.SellIn < 0)
                {
                    this.IncreaseQuality();
                }
            }
        }
    }

    public class Sulfuras : StoredItem
    {
        public Sulfuras(Item item) : base(item) { }
        public override void Update()
        {
        }
    }
}
