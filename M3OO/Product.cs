using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3OO
{
    class Product
    {
        public string Name { get; }
        public string ShortDescription { get; }
        public int ProductNo { get; }
        public int Rating{ get; }
        public int Price{ get; }
        public string Brand { get; }

        public Product(string name, string shortDescription, int productNo, int rating, int price, string brand)
        {
            Name = name;
            ShortDescription = shortDescription;
            ProductNo = productNo;
            Rating = rating;
            Price = price;
            Brand = brand;
        }
    }
}
