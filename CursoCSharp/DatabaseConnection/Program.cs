using System;

namespace DatabaseConnection
{
    class Program
    {
        static void Main(string[] args) {
            // el @ permite que \ sea tomado como parte de la cadena
            DB db = new DB(@"HOME\SQLEXPRESS", "csharpdb", "sa", "b4000$.");
            db.Connect();

            db.Close();
        }
    }
}