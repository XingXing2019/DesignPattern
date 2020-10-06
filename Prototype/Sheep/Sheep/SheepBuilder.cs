using System;

namespace Sheep
{
    public class SheepBuilder : ISheepBuilder
    {
        private BasicInfo _basicInfo;
        public ISheepBuilder ConfigBasicInfo(Action<BasicInfo> basicInfoDelegate)
        {
            _basicInfo = new BasicInfo();
            basicInfoDelegate?.Invoke(_basicInfo);
            return this;
        }

        public SheepBase Build()
        {
            var sheep = new Sheep {BasicInfo = _basicInfo};
            return sheep;
        }
    }
}