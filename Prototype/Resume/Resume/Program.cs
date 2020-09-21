using System;

namespace Resume
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ItResumeBuilder();
            var resume1 = builder
                .ConfigBasicInfo(info =>
                {
                    info.Name = "Tim";
                    info.Age = "25";
                    info.Gender = "Male";
                    info.ExpectedSalary = "100k";
                }).ConfigWorkHistory(work =>
                {
                    work.Company = "Google";
                    work.Detail = "C#";
                    work.StartDate = DateTime.Parse("2019-01-01");
                    work.EndDate = DateTime.Parse("2020-01-01");
                }).Build();
            
            var resume2 = resume1.DeepClone();
            resume2.BasicInfo.ExpectedSalary = "200k";
            resume2.WorkHistory.Detail = "Python";

            resume1.Display();
            Console.WriteLine();
            resume2.Display();

        }
    }
}
