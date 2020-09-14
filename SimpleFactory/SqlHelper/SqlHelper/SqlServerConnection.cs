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
        public override void Close()
        {
            Console.WriteLine("Sql Server Connection Close");
        }
    }
}