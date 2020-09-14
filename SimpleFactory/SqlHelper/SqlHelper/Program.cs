using System;

namespace SqlHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            var helper = new SqlHelper();
            helper.OpenDbConnection();
            helper.CloseDbConnection();
        }
    }
}
