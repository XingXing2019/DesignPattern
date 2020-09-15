namespace SqlHelper
{
    public abstract class DbConnectionFactory
    {
        public abstract IDbConnection CreateDbConnection();
    }
}