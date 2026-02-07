using System;

namespace TiposAnonimos
{
    class Program
    {
        static void Main(string[] args) {
            // 1. Declarando un objeto anonimo. Una vez creado el objeto anonimo no puede ser modificado
            var persona = new {
                Name = "Mario",
                Contry = "Colombia"
            };
            Console.WriteLine($"Los datos de la persona son Nombre: {persona.Name}, Pais: {persona.Contry}");

            // 2. Creando un arreglo de objeto anonimos
            var people = new[] {
                // dentro de una coleccion los objetos anonimos deben tener la misma estructura.
                new
                {
                    Name = "Jorge",
                    Country = "Costa Rica"
                },
                new
                {
                    Name = "Ana",
                    Country = "EEUU"
                }
            };

            foreach (var person in people) {
                Console.WriteLine($"Name: {person.Name}, Country: {person.Country}");
            }
        }
    }
}