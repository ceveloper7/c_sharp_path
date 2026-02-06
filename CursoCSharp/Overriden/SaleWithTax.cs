using System;
using System.Collections.Generic;
using System.Text;

namespace Overriden
{
    public class SaleWithTax : Sale
    {
        private decimal taxSale;
        // La super clase Sale tiene un constructor que recibe un int
        public SaleWithTax(int n, decimal taxSale) : base(n)
        {
            this.taxSale = taxSale;
        }

        // sobrescribimos el metodo GetTotal de la super case Sale
        public override decimal GetTotal()
        {
            return base.GetTotal() * taxSale;
        }
    }
}
