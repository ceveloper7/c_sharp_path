using System;
using System.ComponentModel.DataAnnotations;

namespace SaleSystemSample
{
    class Program
    {
        static void Main(string[] args) {
            var product1 = new Product(1, "Erdinger", 15);
            var product2 = new Product(2, "Delirium", 17);
            var product3 = new Product(3, "Paulaner", 8.80m);

            var customer = new Customer(1, "Carlos");

            var invoice = new Invoice1();
            var sendEmail = new SendEmail();

            var sale = new Sale(1, customer, invoice, sendEmail);
            sale.AddConcept(product1, 2);
            sale.AddConcept(product2, 1);

            Console.WriteLine($"Total sale: {sale.TotalSale}");
        }
    }
}