using System;
using System.Collections.Generic;

// trabajando con LinQ
using System.Linq;


/**
 * LinQ nos permite trabajar con colecciones
 */
namespace LinQ
{
    class Beer {
        private string name;
        private string country;

        public string Name {
            get { return name; }
            set { name = value; }
        }

        public string Country {
            get { return country; }
            set { country = value; }
        }

        public override string ToString()
        {
            return $"Name: {Name}, Country: {Country}";
        }
    }

    class Program
    {
        static void Main(string[] args) {
            List<Beer> beers = new List<Beer>() {
                new Beer(){
                    Name = "Corona", Country = "Mexico"
                },
                new Beer(){
                    Name = "Delirium", Country = "Belgica"
                },
                new Beer(){ 
                    Name = "Erdinger", Country = "Alemania"
                },
                new Beer(){
                    Name = "Cristal", Country = "Peru"
                }
            };

            foreach(Beer beer in beers)
                Console.WriteLine($"Been name: {beer.Name}, country: {beer.Country}");

            Console.WriteLine("--------------------------------");

            // 1. Seleccionar datos, primera forma. Retorna un IEnumerable
            var beerNames = from beer in beers
                           select beer.Name;

            foreach (string bname in beerNames)
                Console.WriteLine(bname);

            // 2. Seleccionar datos, usando tipos anonimos. Retorna un IEnumerable
            var beerData = from beer in beers
                                select new
                                {
                                    Name = beer.Name,
                                    Country = beer.Country,
                                    Length = beer.Country.Length
                                };

            foreach (var beer in beerData) {
                Console.WriteLine($"Name: {beer.Name}, From: {beer.Country}, Length: {beer.Length}");
            }

            // 3. Obtener un listado de objetos anonimos a partir  de otra coleccion de objetos anonimos con LinQ
            var beerCountries = from b in beerData
                                select new {
                                    Name = b.Country,
                                };

            foreach(var country in beerCountries)
                Console.WriteLine($"country name: {country.Name}");

            // 4. Filtrado de informacion. Obtener las beer de Peru, esto retorna una coleccion
            var beersFromMexico = from b in beers
                                  where b.Country == "Peru"
                                  select b;
            foreach(var beer in beersFromMexico)
                Console.WriteLine(beer);

            // 5. Filtrado de informacion usando OR (||)
            var beersFromMexOrPer = from b in beers
                                        where b.Country == "Mexico"
                                        || b.Country == "Peru"
                                        select b;
            foreach(var b in beersFromMexOrPer)
                Console.WriteLine(b);

            // 6. Ordenamiento de una lista por defecto ascending, para descendente, usamos descending
            var orderedBeers = from b in beers
                               orderby b.Country ascending
                               select b;
            foreach( var b in orderedBeers)
                Console.WriteLine(b);
        }   
    }
}