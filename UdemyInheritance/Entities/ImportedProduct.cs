using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyInheritance.Entities
{
    internal class ImportedProduct : Product
    {
        public ImportedProduct()
        {
        }

        public double customsFee { get; set; }

        public ImportedProduct(double customsFee, string name, double price) : base(name, price)
        {
            this.customsFee = customsFee;
        }

        public override string priceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Name);
            sb.Append(" $");
            sb.Append($"{this.Price.ToString("F2", CultureInfo.InvariantCulture)} ");
            sb.Append($"(Customs fee: ${this.customsFee.ToString("F2", CultureInfo.InvariantCulture)})");
            return sb.ToString();
        }
    }
}
