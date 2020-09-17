using System;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var count1 = InheritedLogCounter.Instance.Increase();
            var count2 = InheritedLogCounter.Instance.Increase();
            Console.WriteLine($"Count1: {count1}");
            Console.WriteLine($"Count2: {count2}");
        }
    }
}
