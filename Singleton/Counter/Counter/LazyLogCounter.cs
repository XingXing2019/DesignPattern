using System;

namespace Counter
{
    public class LazyLogCounter
    {
        private static readonly Lazy<LazyLogCounter> _instance = new Lazy<LazyLogCounter>(() => new LazyLogCounter());
        private int _count;
        private LazyLogCounter() { }

        public static LazyLogCounter Instance => _instance.Value;

        public int Increase()
        {
            return ++_count;
        }
    }
}