using System;
using System.Collections.Generic;
using System.Text;

namespace SaleSystemSample
{
    public class Invoice1 : Invoice
    {
        public void create() {
            Console.WriteLine("se genera el archivo .xml version 1");
            Console.WriteLine("se sella el archivo xml");
            Console.WriteLine("se envia a timbrar");
            Console.WriteLine("se guarda");
        }
    }
}
