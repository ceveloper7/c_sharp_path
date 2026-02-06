using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args) {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            numbers.Add(6);

            Console.WriteLine(numbers.Count);

            // otra forma de agregar elementos a la lista
            List<int> numbers2 = new List<int>() {
                1, 2, 3, 4, 5, 6, 7, 8, 9
            };

            Console.WriteLine(numbers2.Count);

            numbers2.Add(10);
            Console.WriteLine(numbers2.Count);

            List<string> countries = new List<string>() {
                "Brasil", "Colombia", "Venezuela"
            };

        }
    }
}