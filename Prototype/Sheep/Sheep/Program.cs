using System;

namespace Sheep
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new SheepBuilder();
            var sheep1 = builder.ConfigBasicInfo(info =>
            {
                info.Name = "Tom";
                info.Age = 2;
                info.Origin = "Australia";
            }).Build();
            sheep1.Display();

            var sheep2 = sheep1.DeepClone();
            sheep2.BasicInfo.Name = "Jack";
            sheep2.Display();
        }
    }
}
