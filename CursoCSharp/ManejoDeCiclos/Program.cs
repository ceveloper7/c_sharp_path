using System;

namespace ManejoDeCiclos{
    class Program
    {
        static void Main(string[] args) {
            int i = 0;

            while (i <= 1000) {
                // rompemos el ciclo
                if (i > 12)
                    break;
                Console.WriteLine("El valor de i " + i);
                i++;
            }
            Console.WriteLine();

            // Array de tipo string de 7 elementos
            string[] friends = new string[7];

            friends[0] = "Alan";
            friends[1] = "Bernal";
            friends[2] = "Camilo";
            friends[3] = "Diana";
            friends[4] = "Ernesto";
            friends[5] = "Fernanda";
            friends[6] = "George";

            int idx = 0;
            while (idx < friends.Length) {
                Console.WriteLine(friends[idx]);
                idx++;
            }
        }
    }
}