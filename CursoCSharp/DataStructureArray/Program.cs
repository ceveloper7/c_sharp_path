using System;

namespace DataStructureArray
{
    class Program
    {
        static void Main(string[] args) {
            // Array de tipo string de 7 elementos
            string[] friends = new string[7];

            friends[0] = "Alan";
            friends[1] = "Bernal";
            friends[2] = "Camilo";
            friends[3] = "Diana";
            friends[4] = "Ernesto";
            friends[5] = "Fernanda";
            friends[6] = "George";

            string[] cities = new string[4] {
                "Lima", "Buenos Aires", "Botoga", null
            };

            Console.WriteLine(friends[4]);
            Console.WriteLine(cities[0]);
        }
    }
}