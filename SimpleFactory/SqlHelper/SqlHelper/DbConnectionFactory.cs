using System;

namespace SqlHelper
{
    public static class DbConnectionFactory
    {
        private static readonly string _dbType = "SqlServer";

        public static DbConnection CreateDbConnection()
        {
            var type = Type.GetType($"SqlHelper.{_dbType}Connection");
            if (type == null)
                return null;
            var obj = (DbConnection) Activator.CreateInstance(type, null);
            return obj;
        }
    }
}