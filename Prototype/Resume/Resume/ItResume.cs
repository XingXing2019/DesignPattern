using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Resume
{
    [Serializable]
    public class ItResume : ResumeBase
    {
        public override void Display()
        {
            Console.WriteLine("Person Information:");
            Console.WriteLine($"Name: {BasicInfo.Name}");
            Console.WriteLine($"Age: {BasicInfo.Age}");
            Console.WriteLine($"Gender: {BasicInfo.Gender}");
            Console.WriteLine($"Expected Salary: {BasicInfo.ExpectedSalary}");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Work History:");
            Console.WriteLine($"Company: {WorkHistory.Company} {WorkHistory.StartDate.ToShortDateString()} - {WorkHistory.EndDate.ToShortDateString()}");
            Console.WriteLine($"Detail {WorkHistory.Detail}");
        }

        public override ResumeBase DeepClone()
        {
            using var stream = new MemoryStream();
            var bf = new BinaryFormatter();
            bf.Serialize(stream, this);
            stream.Position = 0;
            return bf.Deserialize(stream) as ResumeBase;
        }
    }
}