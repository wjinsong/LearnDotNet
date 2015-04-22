using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDotNet
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public DateTime ProduceDate { get; set; }

        public override string ToString()
        {
            return String.Format("{0}{1}{2}{3}{4}{5}",
                this.Id.ToString().PadLeft(2),
                this.Category.PadLeft(1),
                this.Code.PadLeft(7),
                this.Name.PadLeft(17),
                this.Price.ToString().PadLeft(8),
                this.ProduceDate.ToString("yyyy-M-d").PadLeft(13));
        }

    }
    public class ProductCollection
    {
        private List<Product> list = new List<Product>();

    }

}
