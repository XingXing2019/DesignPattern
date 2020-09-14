using System;
using System.Data.Common;

namespace SqlHelper
{
    public abstract class DbConnection
    {
        public abstract void Open();
    }
}