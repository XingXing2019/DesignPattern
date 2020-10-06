using System;

namespace Sheep
{
    public interface ISheepBuilder
    {
        ISheepBuilder ConfigBasicInfo(Action<BasicInfo> basicInfoDelegate);
        SheepBase Build();
    }
}