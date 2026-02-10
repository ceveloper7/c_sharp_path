using System;

namespace POOSample
{
    class Program
    {
        static void Main(string[] args) {
            decimal amount = 10000m;

            var ivaCalculator = new IVaTaxCalulator();
            decimal ivaTax = ivaCalculator.CalculateTax(amount);
            Console.WriteLine(ivaTax);

            var rangeCalculator = new RangeTaxCalculator();
            ivaTax = rangeCalculator.CalculateTax(amount);
            Console.WriteLine(ivaTax);
        }
    }
}