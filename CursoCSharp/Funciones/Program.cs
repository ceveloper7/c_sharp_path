using System;

namespace Funciones
{
    class Program
    {
        // Simple funcion que no recibe parametros ni retorna datos
        static void show() {
            Console.WriteLine("Hello world. C# is awesome");
        }

        // Simple funcion que recibe informacion pero no retorna datos
        static void printMessage(string message) { 
            Console.WriteLine(message); 
        }

        static void suma(int numero1, int numero2) {
            int suma = numero1 + numero2;
            Console.WriteLine(suma);
        }

        static int multiply(int num1, int num2) {
            return num1 * num2;
        }

        static void Main(string[] args)
        {
            show();
            printMessage("Hello world");
            suma(1, 2);

            int rpta = multiply(4,4);
            Console.WriteLine(rpta);
        }
    }
}