using System;

namespace Resume
{
    public class ItResumeBuilder : IResumeBuilder
    {
        private BasicInfo _basicInfo;
        private WorkHistory _workHistory;
        public IResumeBuilder ConfigBasicInfo(Action<BasicInfo> basicInfoDelegate)
        {
            _basicInfo = new BasicInfo();
            basicInfoDelegate?.Invoke(_basicInfo);
            return this;
        }

        public IResumeBuilder ConfigWorkHistory(Action<WorkHistory> workHistoryDelegate)
        {
            _workHistory = new WorkHistory();
            workHistoryDelegate?.Invoke(_workHistory);
            return this;
        }

        public ResumeBase Build()
        {
            var resume = new ItResume
            {
                BasicInfo = _basicInfo,
                WorkHistory = _workHistory
            };
            return resume;
        }
    }
}