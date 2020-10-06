using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Sheep
{
    [Serializable]
    public class Sheep : SheepBase
    {
        public override void Display()
        {
            Console.WriteLine($"Name: {BasicInfo.Name}");
            Console.WriteLine($"Age: {BasicInfo.Age}");
            Console.WriteLine($"Origin: {BasicInfo.Origin}");
        }

        public override SheepBase DeepClone()
        {
            using var stream = new MemoryStream();
            var bf = new BinaryFormatter();
            bf.Serialize(stream, this);
            stream.Position = 0;
            return bf.Deserialize(stream) as SheepBase;
        }
    }
}