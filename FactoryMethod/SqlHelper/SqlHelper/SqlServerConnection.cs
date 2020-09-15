using System;

namespace SqlHelper
{
    public class SqlServerConnection : IDbConnection
    {
        public SqlServerConnection(string connectionString)
        {
                
        }

        public void Open()
        {
            Console.WriteLine("Sql Server Connection Open");
        }

        public void Close()
        {
            Console.WriteLine("Sql Server Connection Close");
        }
    }
}