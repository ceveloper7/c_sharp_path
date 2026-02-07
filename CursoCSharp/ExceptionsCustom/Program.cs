using System;
using System.Linq.Expressions;

namespace ExceptionsCustom
{
    class Program
    {
        public class Beer {
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

            public override string ToString()
            {
                if (name == null || brand == null) {
                    throw new InvalidBeerException();
                }

                return $"Beer: {Name}, Brand: {Brand}";
            }
        }

        static void Main(string[] args) {
            try
            {
                Beer beer = new Beer();
                beer.Name = "London Porter";

                // provocamos una exception
                //beer.Brand = "Fuller's";

                Console.WriteLine(beer);
            }
            catch (InvalidBeerException ex) {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}