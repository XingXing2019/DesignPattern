namespace SdReader
{
    public class Computer
    {
        private IUsb _usb;

        public void SetUsb(IUsb usb)
        {
            _usb = usb;
        }

        public void Display()
        {
            _usb.Request();
        }
    }
}