using System;

namespace JsonFormat
{
    public class Beer {
        private string name;
        private string brand;

        public string Name {
            get { return name; }
            set { name = value; }
        }

        public string Brand {
            get { return brand; }
            set { brand = value; }
        }
    }

    class Program {
        static void Main(string[] args) {
            Beer myBeer = new Beer()
            {
                Name = "Rubia",
                Brand = "Cristal"
            };

            // Representacion a JSON de un objeto
            string jsonBeer = "{\"Name\": \"Rubia\", \"Brand\": \"Cristal\" }";

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

            // Representacion a JSON de un array de objetos
            string jsonBeerArray = "[" +
                "{\"Name\": \"Rubia\", \"Brand\": \"Cristal\"}" +
                "{\"Name\": \"Corona\", \"Brand\": \"Modelo\"}" +
                "]";
        }
    }
}