using System;

namespace SqlHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlHeler = new SqlHelper();
            sqlHeler.OpenDbConnection();
        }
    }
}
