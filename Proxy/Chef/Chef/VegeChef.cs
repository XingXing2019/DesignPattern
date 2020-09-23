namespace Chef
{
    public class VegeChef : IChef
    {
        public string Cook(string[] vegetables)
        {
            return $"good: {string.Join("+", vegetables)}";
        }
    }
}