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

        public static void deleteBeer(BeerDB beerDB)
        {
            Console.Clear();
            getAllBeerData(beerDB);

            Console.WriteLine("Delete beer information");
            Console.WriteLine("Enter beer id to delete");
            int beerId = int.Parse(Console.ReadLine());

            Beer beer = beerDB.get(beerId);
            if (beer != null) {
                beerDB.delete(beerId);
            }
            else
            {
                Console.WriteLine("Beer doesnt exist");
            }
        }

        public static void updateBeer(BeerDB beerDB) {
            Console.Clear();
            getAllBeerData(beerDB);

            Console.WriteLine("Update beer information");
            Console.WriteLine("Enter beer id");
            int beerId = int.Parse(Console.ReadLine());

            // podemos recuperar de la BD beer, si no existe retorna null, hay que manipular el null
            Beer beer = beerDB.get(beerId);
            if (beer != null)
            {
                Console.WriteLine("Enter beer name to update");
                string name = Console.ReadLine();

                Console.WriteLine("Enter beer brand id to update");
                int brandId = int.Parse(Console.ReadLine());

                beer.Name = name;
                beer.BrandId = brandId;

                beerDB.update(beer);
            }
            else
            {
                Console.WriteLine("Beer doesnt exist");
            }
        }

        public static void addBeer(BeerDB beerDB) {
            Console.Clear();
            Console.WriteLine("Add new Beer");
            Console.WriteLine("Enter beer name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter beer brand id");
            int brandId = int.Parse(Console.ReadLine());

            Beer beer = new Beer(name, brandId);
            beerDB.Add(beer);
        }

        public static void getAllBeerData(BeerDB beerDB) {
            Console.Clear();
            Console.WriteLine("Getting all Beers from Database...");
            List<Beer> beers = beerDB.GetAll();
            foreach (Beer beer in beers)
                Console.WriteLine($"Beer id: {beer.Id}, Name: {beer.Name}, Brand id: {beer.BrandId}");

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
                        case 2:
                            addBeer(beerDb);
                            break;
                        case 3:
                            updateBeer(beerDb);
                            break;
                        case 4:
                            deleteBeer(beerDb);
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