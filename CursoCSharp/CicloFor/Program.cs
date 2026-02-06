using System;

namespace CicloFor
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

            // podemos agregar condiciones al for
            bool run = true;
            for (int i = 0; i < friends.Length && run; i++) {
                Console.WriteLine(friends[i]);
            }
        }
    }
}