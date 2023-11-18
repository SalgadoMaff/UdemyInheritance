using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyInheritance.Entities
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

        public virtual string priceTag()
        {
            return $"{this.Name} ${this.Price.ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
