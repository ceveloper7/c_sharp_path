using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseConnection
{
    public class DB
    {
        private string _connectionString;
        protected SqlConnection _connection;

        // parametros requeridos para construir una conexion basica a un base de datos
        public DB(string server, string dbName, string user, string password) {
            _connectionString = $"Data Source={server}; Initial Catalog={dbName}; User={user}; Password={password}; TrustServerCertificate=True";
        }

        public void Connect() {
            _connection = new SqlConnection(_connectionString); 
            _connection.Open();
        }

        public void Close() {
            if(_connection != null && _connection.State == System.Data.ConnectionState.Open) 
                _connection.Close();
        }
    }
}
