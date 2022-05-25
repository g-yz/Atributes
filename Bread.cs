namespace Marketplace
{
    using System;
    using System.Reflection;
    using System.Web;

    public abstract class Bread
    {
        public List<string> _ingredients {get; set;}
        [Tab]
        [Tab]
        [Tab]
        [Tab]
        [Tab]
        [Tab]
        public BreadType _type {get; set;}
        [Tab]
        public double _price {get; set;}
        [Tab]
        [Tab]
        public BreadType Type { get { return _type; } }
        [Tab]
        [Version(1.1)]
        public virtual double Price { get => _price; set { _price = value; } }

        public List<string> Ingredients { get { return _ingredients; } }

        public Bread(List<string> ingredients, BreadType bread)
        {
            _ingredients = ingredients;
            _type = bread;
        }
    }

    public class Baguette : Bread
    {
        public Baguette() : base(
                new List<string>() { "Harina", "Levadura", "Agua", "Sal" },
                BreadType.Bagette
            )
        {
            Price = 0.5;
        }
    }

    public class BreadPrinter
    {
        private readonly Bread _bread;

        public BreadPrinter(Bread bread)
        {
            _bread = bread;
        }

        public void Write()
        {
            Console.WriteLine(_bread.Type);
            Console.WriteLine(_bread.Price);
            foreach (var ingredient in _bread.Ingredients)
                Console.WriteLine(ingredient);
        }
    }

    public enum BreadType
    {
        Bagette,
        Hamburger,
        MilkBread,
        WhiteBread
    }
}
