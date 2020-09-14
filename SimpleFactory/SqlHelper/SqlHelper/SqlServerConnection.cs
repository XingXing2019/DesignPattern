using System;
using System.Data.Common;

namespace SqlHelper
{
    public class SqlServerConnection : DbConnection
    {
        public override void Open()
        {
            Console.WriteLine("Sql Server Connection Open");
        }
    }
}