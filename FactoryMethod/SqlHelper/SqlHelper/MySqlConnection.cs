using System;

namespace SqlHelper
{
    public class MySqlConnection : IDbConnection
    {
        public MySqlConnection(string connectionString)
        {
            
        }

        public void Open()
        {
            Console.WriteLine("MySql Connection Open");
        }

        public void Close()
        {
            Console.WriteLine("MySql Connection Close");
        }
    }
}