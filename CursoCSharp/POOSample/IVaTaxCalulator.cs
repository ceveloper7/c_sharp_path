using System;
using System.Collections.Generic;
using System.Text;

namespace POOSample
{
    public class IVaTaxCalulator : TaxCalculator
    {
        public IVaTaxCalulator() : base(0.16m) { }

        protected override decimal ApplyTax(decimal amount)
        {
            return amount * TaxRate;
        }
    }
}
