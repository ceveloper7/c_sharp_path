using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Data.SqlClient;

namespace DatabaseConnection
{
    public class BeerDB : DB
    {
        public BeerDB(string server, string dbName, string user, string password) : base(server, dbName, user, password) {

        }

        public void update(Beer beer) {
            Connect();
            string query = "UPDATE beer SET name=@name, brandId = @brandId WHERE id=@id";
            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@id", beer.Id);
            command.Parameters.AddWithValue("@name", beer.Name);
            command.Parameters.AddWithValue("@brandId", beer.BrandId);
            command.ExecuteNonQuery();

            Close();
        }

        public Beer get(int id) {
            Connect();
            Beer beer = null;
            string query = "SELECT id, name, brandId FROM beer WHERE id =@id";
            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("id", id);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string name = reader.GetString(1);
                int brandId = reader.GetInt32(2);

                beer = new Beer(id, name, brandId);
            }


            Close();
            return beer;
        }

        public void Add(Beer beer) {
            Connect();
            string query = "INSERT INTO beer (name, brandId) VALUES(@name, @brandId)";
            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@name", beer.Name);
            command.Parameters.AddWithValue("@brandId", beer.BrandId);
            // Execute sin obtener resultados
            command.ExecuteNonQuery();

            Close();
        }

        public List<Beer> GetAll() {
            // abrimos una conexion a la BD
            Connect();
            List<Beer> beers = new List<Beer>();
            string query = "SELECT id, name, brandId FROM beer";
            
            // enviamos query sql a la BD
            SqlCommand command = new SqlCommand(query, _connection);
            // Executamos el command y obtenemos los datos
            SqlDataReader reader = command.ExecuteReader();

            // llenamos beers list, mientras exista una fila por leer
            while (reader.Read()) {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                int brandId = reader.GetInt32(2);

                Beer beer = new Beer(id, name, brandId);
                beers.Add(beer);
            }

            Close();

            return beers;
        }
    }
}
