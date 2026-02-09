using Azure.Core;
using DB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace WorkingWithEntityFramework
{
    class Program
    {
        public static void ShowMenu()
        {
            Console.WriteLine("\n--------- Menu -----------");
            Console.WriteLine("1. Mostrar");
            Console.WriteLine("2. Agregar");
            Console.WriteLine("3. Editar");
            Console.WriteLine("4. Eliminar");
            Console.WriteLine("5. Salir");
        }

        public static void Delete(DbContextOptionsBuilder<CsharpdbContext> optionsBuilder) {
            Console.Clear();
            Show(optionsBuilder);

            Console.WriteLine("Delete beer data");
            Console.WriteLine("Enter beer id to delete");
            int id = int.Parse(Console.ReadLine());

            using (var ctx = new CsharpdbContext(optionsBuilder.Options)) {
                // obtenemos la cerveza
                Beer beer = ctx.Beers.Find(id);
                if (beer != null)
                {
                    ctx.Beers.Remove(beer);
                    ctx.SaveChanges();
                }
                else {
                    Console.WriteLine("Beer doesnt exists");
                }
            }

        }

        public static void Edit(DbContextOptionsBuilder<CsharpdbContext> optionsBuilder) {
            Console.Clear();
            Show(optionsBuilder);
            Console.WriteLine("Edit beer data");
            Console.WriteLine("Write Beer's id to edit");
            int id = int.Parse(Console.ReadLine());

            using (var ctx = new CsharpdbContext(optionsBuilder.Options)) {
                Beer beer = ctx.Beers.Find(id);
                if (beer != null)
                {
                    Console.WriteLine("Enter a beer name:");
                    string name = Console.ReadLine();

                    Console.WriteLine("Enter a beer's brand id:");
                    int brandId = int.Parse(Console.ReadLine());

                    beer.Name = name;
                    beer.BrandId = brandId;

                    // indicamos al entity framework que la entidad Beer ha sido modificada
                    ctx.Entry(beer).State = EntityState.Modified;
                    ctx.SaveChanges();
                }
                else {
                    Console.WriteLine("Beer doesnt exists");
                }
            }
        }

        public static void Add(DbContextOptionsBuilder<CsharpdbContext> optionsBuilder)
        {
            Console.Clear();
            Console.WriteLine("Add new Beer");
            Console.WriteLine("Enter a name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter beer's brand id");
            int brandId = int.Parse(Console.ReadLine());

            using (var ctx = new CsharpdbContext(optionsBuilder.Options))
            {
                Beer beer = new Beer() {
                    Name = name,
                    BrandId = brandId
                };
                ctx.Add(beer);
                ctx.SaveChanges();
            }
         }

        public static void Show(DbContextOptionsBuilder<CsharpdbContext> optionsBuilder) {
            Console.Clear();
            Console.WriteLine("Beer in the Database");
            // connection
            using (var ctx = new CsharpdbContext(optionsBuilder.Options))
            {
                //List<Beer> beers = ctx.Beers.OrderBy(b => b.Name).ToList();

                // equivalente usando LinQ. Include hace un join con la tabla Brand
                List<Beer> beers2 = (from b in ctx.Beers orderby b.Name
                                     select b).Include(b => b.Brand).ToList();
                foreach (var beer in beers2)
                    Console.WriteLine($"Beer id: {beer.Id} name: {beer.Name}, Brand: {beer.Brand.Name}");
            }
        }

        static void Main(string[] args) {
            DbContextOptionsBuilder<CsharpdbContext> optionsBuilder = new DbContextOptionsBuilder<CsharpdbContext>();
            optionsBuilder.UseSqlServer("Server=HOME\\SQLEXPRESS; Database=csharpdb; User=sa; Password=b4000$.; Trusted_Connection=True; TrustServerCertificate=True");


            bool again = true;
            int opt = 0;

            do {
                ShowMenu();
                Console.WriteLine("Elige una opcion");
                opt = int.Parse(Console.ReadLine());
                switch (opt) {
                    case 1:
                        Show(optionsBuilder);
                        break;
                    case 2:
                        Add(optionsBuilder);
                        break;
                    case 3:
                        Edit(optionsBuilder);
                        break;
                    case 4:
                        Delete(optionsBuilder);
                        break;
                    case 5:
                        again = false;
                        break;
                }
            }while (again);
/*
            // Crear la conexion a la BD
            using (CsharpdbContext ctx = new CsharpdbContext(optionsBuilder.Options)) 
            {
                //// get all beers
                //var beers = ctx.Beers.ToList();
                //foreach (var beer in beers)
                //    Console.WriteLine($"Beer name: {beer.Name}, Brand id: {beer.BrandId}");
            }
*/
           
        }
    }
}