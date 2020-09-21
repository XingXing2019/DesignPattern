using System;

namespace Resume
{
    [Serializable]
    public class BasicInfo
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string ExpectedSalary { get; set; }
    }
}