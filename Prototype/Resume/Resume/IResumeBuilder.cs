using System;

namespace Resume
{
    public interface IResumeBuilder
    {
        IResumeBuilder ConfigBasicInfo(Action<BasicInfo> basicInfoDelegate);
        IResumeBuilder ConfigWorkHistory(Action<WorkHistory> workHistoryDelegate);
        ResumeBase Build();
    }
}