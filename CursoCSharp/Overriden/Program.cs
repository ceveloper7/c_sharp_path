using System;

namespace Overriden {

    public class A {
        // virtual permite que el metodo sea sobrescrito por alguna subclase
        public virtual string Saludar() {
            return "Hola soy A";
        }
    }
    public class B : A {
        // con override indica que el metodo va a ser modificado
        // base.Saludar() llama al metodo Saludar de la super clase A
        public override string Saludar() {
            return base.Saludar() + ", Hola soy B";
        }
    }

    class Program {
        static void Main(string[] args) {
            B b = new B();
            Console.WriteLine(b.Saludar());

            Sale sale = new Sale(10);

            sale.Add(2);
            sale.Add(3);

            Console.WriteLine(sale.GetTotal());

            SaleWithTax saleWithTax = new SaleWithTax(10, 1.16m);
            saleWithTax.Add(2);
            saleWithTax.Add(3);

            Console.WriteLine(saleWithTax.GetTotal());

        }
    }
}