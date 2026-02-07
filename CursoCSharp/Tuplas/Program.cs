using System;

namespace Tuplas
{
    class Program
    {
        static void Main(string[] args) {
            // Las tupas son una lista de distintas variables que tienen diferente tipos de datos
            // 1. Declaracion de una Tupla
            (int id, string name) product = (1, "Ferrari");

            // 2. Accediendo a los datos de una Tupla
            Console.WriteLine($"Product info id: {product.id}, name: {product.name}");

            // 3. A diferencia de los tipos anonimos que no son editables, las tuplas si permiten la edicion de sus valores
            product.name = "Ferrari Logo";
            Console.WriteLine($"car model {product.name}");

            // 4. Otra forma valida de declarar una Tupla
            var person = (1, "Jose Alberto");
            Console.WriteLine($"Person data id: {person.Item1}, name: {person.Item2}");

            // 5. Declarando un array de tuplas
            var countries = new[] {
                (1, "Argentina"),
                (2, "Colombia"),
                (3, "Brasil"),
                (4, "Chile")
            };

            foreach (var country in countries) {
                Console.WriteLine($"Contruy info: {country.Item1}, {country.Item2}");
            }

            // 6. Declarando una tupla, especificando el tipo y nombre
            // A continuacion declaramos un array de tuplas
            (int id, string name)[] names = new[] {
                (1, "Mario"), (2, "Antonia"), (3, "Pedro"), (4, "Angel")
            };

            foreach (var n in names) {
                Console.WriteLine($"Data id: {n.id}, name: {n.name}");
            }

            // 7. Las tuplas nos ayudan en el caso que deseamos que una funcion retorne mas de un valor
            // invocando una funcion que retorna una Tupla
            var cityLocation = getLocation();
            Console.WriteLine($"City location: Lat:{cityLocation.lat}, Lng:{cityLocation.lng}, Name:{cityLocation.cityName}");

            // 8. Hay ocasiones donde la tupla trae mucha informacion pero yo solo quiero un dato de la tupla y no todo
            // con el guion bajo (_) indicamos que se ignore el dato en ese posicion de la tupla
            // De la funcion getLocation() que retorna una tupla (float, float, string) yo solo quiero el segundo valor
            // e ignorar el primer y tercer valor de la tupla
            var (_, lng, _) = getLocation();
            Console.WriteLine($"La longitud: {lng}");

        }

        // Metodo que retorna una Tupla
        public static (float lat, float lng, string cityName) getLocation() {
            float lat = 7564757f;
            float lng = 4755739f;
            string cityName = "CDMX";

            // retornamos 3 valores desde la funcion getLocaltion()
            return (lat, lng, cityName);
        }
    }
}