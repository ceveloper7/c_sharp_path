using System;
using System.Collections.Generic;
using System.Text;

namespace SaleSystemSample
{
    public class SendEmail : Send
    {
        public void Send(string contenrt) {
            Console.WriteLine("Se envia por correo");
        }
    }
}
