using System;
using System.Collections.Generic;
using System.Text;

namespace SaleSystemSample
{
    public class Product
    {
        // propiedades
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(int id, string name, decimal price) {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}
