namespace Counter
{
    public class LogCounter
    {
        private static volatile LogCounter _instance;
        private static object _lock = new object();
        private int _count;

        private LogCounter() { }

        public static LogCounter Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if(_instance == null)
                            _instance = new LogCounter();
                    }
                }
                return _instance;
            }
        }

        public int Increase()
        {
            return ++_count;
        }
    }
}