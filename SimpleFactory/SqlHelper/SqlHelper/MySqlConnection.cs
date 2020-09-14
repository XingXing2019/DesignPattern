using System;

namespace SqlHelper
{
    public class MySqlConnection : DbConnection
    {
        public override void Open()
        {
            Console.WriteLine("MySql Connection Open");
        }

        public override void Close()
        {
            Console.WriteLine("MySql Connection Close");
        }
    }
}