using System;

namespace HomeControl
{
    class Program
    {
        static void Main(string[] args)
        {
            IHomeControl homeControl = new HomeControl();
            homeControl.GetHome();
            Console.WriteLine("-------------------");
            homeControl.LeaveHome();
        }
    }
}
