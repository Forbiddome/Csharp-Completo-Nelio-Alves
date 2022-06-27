
using System.Globalization;

namespace _17ex01_02_03_04_05_06.src
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public Product()
        {
        }

        public static Product ReturnToUpper(object obj)
        {

            if (!(obj is Product)) throw new ArgumentException("Object obj is not a Product");
            Product pToUpper = obj as Product;
            pToUpper.Name = pToUpper.Name.ToUpper();
            return pToUpper;
        }
        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
