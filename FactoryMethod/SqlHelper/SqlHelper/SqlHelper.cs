namespace SqlHelper
{
    public class SqlHelper
    {
        private readonly DbConnectionFactory _connectionFactory;

        public SqlHelper(DbConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public void OpenDbConnection()
        {
            var connection = _connectionFactory.CreateDbConnection();
            connection.Open();
        }

        public void CloseDbConnection()
        {
            var connection = _connectionFactory.CreateDbConnection();
            connection.Close();
        }
    }
}