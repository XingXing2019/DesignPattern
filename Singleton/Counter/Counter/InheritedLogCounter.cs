namespace Counter
{
    public class InheritedLogCounter : SingletonBase<InheritedLogCounter>
    {
        private int _count;
        private InheritedLogCounter() { }

        public int Increase()
        {
            return ++_count;
        }
    }
}