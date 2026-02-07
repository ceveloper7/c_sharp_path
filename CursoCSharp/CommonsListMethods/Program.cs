using System;
using System.Collections.Generic;

namespace CommonsListMethods
{
    class Program
    {
        static void Main(string[] args) {
            List<int> numbers = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16
            };

            Show(numbers);

            // 1. Insertar el elemento en una posicion
            numbers.Insert(16, 17); // posicion 16, elemento 17 
            Show(numbers);

            // 2. Verificar la existencia de un elemento
            if (numbers.Contains(10))
                Console.WriteLine("Item 10, exists");
            else
                Console.WriteLine("Item 10, doesnt exists");

            // 3. Obtener la posicion de un elemento en la lista, si este se encuentra. De lo contrario retorna -1
            int pos = numbers.IndexOf(10);
            Console.WriteLine("Index position of item 10 is: " + pos);

            // 4. Ordenamiento
            numbers.Sort();
            Show(numbers);

            // 5. Add a range
            numbers.AddRange(new List<int>
            {
                50, 51,52
            });
            Show(numbers);
        }

        private static void Show(List<int> numbers) {
            Console.WriteLine("-- Numeros --");
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}