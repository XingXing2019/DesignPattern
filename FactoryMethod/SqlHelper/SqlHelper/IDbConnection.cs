namespace SqlHelper
{
    public interface IDbConnection
    {
        void Open();
        void Close();
    }
}