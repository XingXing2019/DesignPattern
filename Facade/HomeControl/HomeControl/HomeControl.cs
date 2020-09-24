namespace HomeControl
{
    public class HomeControl : IHomeControl
    {
        private Tv tv = new Tv();
        private AirConditioner airConditioner = new AirConditioner();
        private Light light = new Light();
        public void GetHome()
        {
            light.TurnOn();
            tv.TurnOn();
            airConditioner.TurnOn();
        }

        public void LeaveHome()
        {
            airConditioner.TurnOff();
            tv.TurnOff();
            light.TurnOff();
        }
    }
}