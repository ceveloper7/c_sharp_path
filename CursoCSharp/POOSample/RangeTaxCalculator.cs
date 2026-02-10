using System;
using System.Collections.Generic;
using System.Text;

namespace POOSample
{
    public class RangeTaxCalculator : TaxCalculator
    {
        public RangeTaxCalculator() : base(0.0m) { }

        protected override decimal ApplyTax(decimal amount) {
            if(amount <= 1000)
                return amount * 0.10m;

            if (amount <= 5000)
                return amount * 0.20m;

            return amount * 0.30m;
        }
    }
}
