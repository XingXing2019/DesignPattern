using System;

namespace SqlHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            var helper = new SqlHelper(new MySqlConnectionFactory());
            helper.OpenDbConnection();
            helper.CloseDbConnection();
        }
    }
}
