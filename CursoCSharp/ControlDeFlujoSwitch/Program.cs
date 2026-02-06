using System;

namespace ControlDeFlujoSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int opt = 5;

            switch (opt) {
                case 1:
                    Console.WriteLine("Opcion 1 Seleccionada");
                    break;
                case 2:
                    Console.WriteLine("Opcion 2 Seleccionada");
                    break;
                case < 0:
                    Console.WriteLine("Fuera de rango");
                    break;
                case >= 3 and < 10:
                    Console.WriteLine("Seleccionaste una opcion entre 3 y 10");
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }
        }
    }
}