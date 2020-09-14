using System.Data.Common;
using System.Data.SqlClient;

namespace SqlHelper
{
    public class SqlHelper
    {
        public void OpenDbConnection()
        {
            var conn = DbConnectionFactory.CreateDbConnection();
            conn.Open();
        }

        public void CloseDbConnection()
        {
            var conn = DbConnectionFactory.CreateDbConnection();
            conn.Close();
        }
    }
}