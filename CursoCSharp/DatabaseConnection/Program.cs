using System;

namespace DatabaseConnection
{
    class Program
    {
        public static void showMenu() {
            Console.WriteLine("\nSelecciona una opcion");
            Console.WriteLine("=====================");
            Console.WriteLine("1. Get all beers");
            Console.WriteLine("2. Add a new Beer");
            Console.WriteLine("3. Edit beer information");
            Console.WriteLine("4. Delete a beer");
            Console.WriteLine("5. Exit from System");
            Console.WriteLine();
        }

        public static void getAllBeerData(BeerDB beerDb) {
            Console.Clear();
            Console.WriteLine("Getting all Beers from Database...");
            List<Beer> beers = beerDb.GetAll();
            foreach (Beer beer in beers)
                Console.WriteLine($"Beer: {beer.Id}, {beer.Name}");

            Console.WriteLine();
        }

        static void Main(string[] args) {
            try
            {
                // el @ permite que \ sea tomado como parte de la cadena
                BeerDB beerDb = new BeerDB(@"HOME\SQLEXPRESS", "csharpdb", "sa", "b4000$.");

                bool again = true;
                int op = 0;

                do
                {
                    showMenu();
                    Console.WriteLine("Choose an option...");
                    op = int.Parse(Console.ReadLine());

                    switch (op) {
                        case 1:
                            getAllBeerData(beerDb);
                            break;
                        case 5:
                            again = false;
                            break;
                    }

                }while (again);

              
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
            }
        }
    }
}