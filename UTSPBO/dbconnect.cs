using System;
using MySql.Data.MySqlClient;
namespace PesenMinum
{
    public class connect
    {
        private static string connectionstring =  "server=localhost; port=3306; uid=Fatinn; database=database_pesenminum; charset=utf8; sslMode=none;";
        private static MySqlConnection _connection = new MySqlConnection(connectionstring);

        public MySqlConnection connection{
            get{return _connection;}
        }
    }

}