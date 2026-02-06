using System;

namespace Propiedades
{
    class Sale {
        private double total;
        private DateTime date;

        public Sale() {
            this.total = 0;
            this.date = DateTime.Now;
        }

        public Sale(double total, DateTime date) {
            this.total = total;
            this.date = date;  
        }

        // Accessor methods
        public double Total
        {
            get
            {
                // Total string with format
                //return this.total.ToString("#.00"); 
                return this.total;
            }
            set
            {
                if (value < 0)
                    value = 0;

                this.total = value;
            }
        }

        public string Date {
            get { return this.date.ToLongDateString(); }
        }
    }

    class Program {
        static void Main(string[] args) {
            Sale sale = new Sale(100000, DateTime.Now);
            sale.Total = -94955;
            Console.WriteLine("Sale amount: " + sale.Total);
            Console.WriteLine("Sale Date time: " + sale.Date);
        }
    }
}