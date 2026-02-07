using System;
using System.Collections.Generic;
using System.Text;

namespace SaleSystemSample
{
    public class Sale
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public List<Concept> Concepts { get; set; }
        public DateTime Date { get; set; }

        // atributos privados
        private Invoice _invoice;
        private Send _send;

        public Sale(int id, Customer customer, Invoice invoice, Send send) {
            this.Id = id;
            this.Customer = customer;
            this.Concepts = new List<Concept>();
            this.Date = DateTime.Now;
            this._invoice = invoice;
            this._send = send;
        }

        public void AddConcept(Product product, int quantity) {
            Concepts.Add(new Concept(product, quantity));
        }

        public decimal TotalSale {
            get
            {
                decimal total = 0;
                foreach (Concept concept in Concepts)
                    total += concept.SubTotal;
                return total;
            }
        }

        public void createInvoice() {
            _invoice.create();
            _send.Send("sending invoice...");
        }
    }
}
