using DB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace WorkingWithEntityFramework
{
    class Program
    {
        static void Main(string[] args) {
            DbContextOptionsBuilder<CsharpdbContext> optionsBuilder = new DbContextOptionsBuilder<CsharpdbContext>();
            optionsBuilder.UseSqlServer("Server=HOME\\SQLEXPRESS; Database=csharpdb; User=sa; Password=b4000$.; Trusted_Connection=True; TrustServerCertificate=True");

            // Crear la conexion a la BD
            using (CsharpdbContext ctx = new CsharpdbContext(optionsBuilder.Options)) 
            {
                // get all beers
                var beers = ctx.Beers.ToList();
                foreach (var beer in beers)
                    Console.WriteLine($"Beer name: {beer.Name}, Brand id: {beer.BrandId}");
            }
           
        }
    }
}