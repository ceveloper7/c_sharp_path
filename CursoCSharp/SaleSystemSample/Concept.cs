using System;
using System.Collections.Generic;
using System.Text;

namespace SaleSystemSample
{
    public class Concept
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public Concept(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        // propiedad con comportamiento.
        public decimal SubTotal
        {
            get
            {
                return Product.Price * Quantity;
            }
        }
    }
}
