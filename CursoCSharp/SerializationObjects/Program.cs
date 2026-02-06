using System;
using System.Text.Json;

namespace SerializationObjects
{
    public class Beer
    {
        private string name;
        private string brand;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
    }

    class Program {
        static void Main(string[] args) {
            Beer beer = new Beer() {
                Name = "Corona",
                Brand = "Modelo"
            };

            // Convertir un objeto C# a JSON
            string json = JsonSerializer.Serialize(beer);
            Console.WriteLine(json);

            Beer[] beers = new Beer[] {
                new Beer(){
                    Name = "Rubia",
                    Brand = "Cristal"
                },

                new Beer(){
                    Name = "Corona",
                    Brand = "Modelo"
                }
            };

            string jsonBeers = JsonSerializer.Serialize(beers);
            Console.WriteLine(jsonBeers);
        }
    }
}