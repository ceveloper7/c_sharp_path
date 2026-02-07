using System;
using System.Collections.Generic;
using System.Linq;

/**
 * LINQ JOIN -> nos sirve para unir dos colecciones de informacion
 */
namespace LinqJoin
{
    public class Beer {
        private string name;
        private string country;

        public string Name {
            get { return name; }
            set { name = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }
    }

    public class Country
    {
        private string name;
        private string continent;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Continent
        {
            get { return continent; }
            set { continent = value; }
        }
    }

    class Program {
        static void Main(string[] args) {
            var beers = new List<Beer> {
                new Beer(){
                    Name = "Corona", Country = "Mexico"
                }, 
                
                new Beer(){
                    Name = "Delirium", Country = "Belgica"
                }, 
                
                new Beer(){
                    Name = "Erdinger", Country = "Alemania"
                }
            };

            var countries = new List<Country> {
                new Country()
                {
                    Name = "Mexico", Continent = "America"
                },

                new Country(){
                    Name = "Belgica", Continent = "Europa"
                },

                new Country(){
                    Name = "Alemania", Continent = "Europa"
                }
            };

            // 1. Uniendo las listas beers & countries usando LINQ
            var beerWithContinent = from beer in beers
                                    join country in countries
                                    on beer.Country equals country.Name
                                    select new
                                    {
                                        Name = beer.Name,
                                        Country = beer.Country,
                                        Continent = country.Continent
                                    };

            foreach (var beer in beerWithContinent)
                Console.WriteLine($"beer: {beer.Name}, from: {beer.Country} - {beer.Continent}");
        }
    }
}