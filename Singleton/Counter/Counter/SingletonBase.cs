using System;

namespace Counter
{
    public class SingletonBase<TSingleton>
    {
        private static readonly Lazy<TSingleton> _instance =
            new Lazy<TSingleton>(() => (TSingleton) Activator.CreateInstance(typeof(TSingleton), true));

        protected SingletonBase() { }

        public static TSingleton Instance => _instance.Value;
    }
}