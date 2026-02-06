using System;

namespace Classes
{
    class Sale {
        private double total;
        private DateTime date;

        // Constructor por defecto
        public Sale() {
            this.total = 0;
            this.date = DateTime.Now;
        }

        // Constructor personalizado
        public Sale(double total, DateTime date) {
            this.total = total;
            this.date = date;
        }

        public string getInfo() {
            return total + " " + date.ToLongDateString();
        }

        public void show() {
            Console.WriteLine("Hola soy una venta");
        }
    }

    class Program {
        static void Main(string[] args) {
            Sale sale1 = new Sale(450000, DateTime.Now);
            string info = sale1.getInfo();
            Console.WriteLine(info);
        }
    }
}