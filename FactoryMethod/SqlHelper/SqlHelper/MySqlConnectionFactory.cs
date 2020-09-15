using System.Runtime.InteropServices.ComTypes;

namespace SqlHelper
{
    public class MySqlConnectionFactory : DbConnectionFactory
    {
        private readonly string connectionString = "MySqlConnectionString";
        public override IDbConnection CreateDbConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}