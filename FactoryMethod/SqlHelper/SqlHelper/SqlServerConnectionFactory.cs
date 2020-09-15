namespace SqlHelper
{
    public class SqlServerConnectionFactory : DbConnectionFactory
    {
        private readonly string connectionString = "SqlServerConnectionString";
        public override IDbConnection CreateDbConnection()
        {
            return new SqlServerConnection(connectionString);
        }
    }
}