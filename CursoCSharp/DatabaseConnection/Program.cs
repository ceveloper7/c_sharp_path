using System;

namespace DatabaseConnection
{
    class Program
    {
        static void Main(string[] args) {
            try
            {
                // el @ permite que \ sea tomado como parte de la cadena
                BeerDB beerDb = new BeerDB(@"HOME\SQLEXPRESS", "csharpdb", "sa", "b4000$.");
                beerDb.Connect();

                List<Beer> beers = beerDb.GetAll();
                foreach (Beer beer in beers)
                    Console.WriteLine($"Beer: {beer.Id}, {beer.Name}");

                beerDb.Close();
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
            }
        }
    }
}