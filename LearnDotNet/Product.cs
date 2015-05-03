using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

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

        //public static ProductCollection GetSampleCollection()
        //{
        //    ProductCollection colletion = new ProductCollection(
        //        new Product{ Id =1, Name="Torres Coronas", Price=1000, Code="1001", Category= "Red wine", ProduceDate=DateTime.Parse("1977-12-8")});
        //    return colletion;
        //}

    }
    public class ProductCollection
    {
        //private List<Product> list = new List<Product>();

        private Hashtable table;
        //public ProductCollection()
        //{
        //    table = new Hashtable();

        //}

        //public ProductCollection(params Product[] array)
        //{
        //    table = new Hashtable();
        //    foreach (Product item in array)
        //    {
        //        this.Add(item);
        //    }
        //}
        //public Product this[int index]
        //{ get; set; }
        
        //public Product this[string key]
        //{ get; set; }

        //public void Add(Product item)
        //{ 
        //}
        
        //public int Count { get; }

        //public void Clear()
        //{
        //    table = new Hashtable();
        //}

    }

}
