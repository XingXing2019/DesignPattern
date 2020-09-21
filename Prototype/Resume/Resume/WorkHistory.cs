using System;

namespace Resume
{
    [Serializable]
    public class WorkHistory
    {
        public string Company { get; set; }
        public string Detail { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}