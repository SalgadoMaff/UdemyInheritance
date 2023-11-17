using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyInheritance.Entities
{
    internal class UsedProduct : Product
    {
        public UsedProduct()
        {
        }

        public DateTime manufacturedDate { get; set; }

        public UsedProduct(DateTime manufacturedDate, string name, double price) : base(name, price)
        {
            this.manufacturedDate = manufacturedDate;
        }

        public override string priceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.Name} (used) $");
            sb.Append($"{this.Price.ToString("F2", CultureInfo.InvariantCulture)} ");
            sb.Append($"(Manufactured date: ${this.manufacturedDate.Date.Day}/{this.manufacturedDate.Date.Month}/{this.manufacturedDate.Date.Year})");
            return sb.ToString();
        }
    }
}
