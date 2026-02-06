using System;

namespace CicloDoWhile
{
    class Program
    {
        static void Main(string[] args) {
            bool run = false;

            // do-while realiza la ejecucion del ciclo aunque sea una vez
            do {
                Console.WriteLine("Inicio de la ejecucion");
            } while (run);
        }
    }
}