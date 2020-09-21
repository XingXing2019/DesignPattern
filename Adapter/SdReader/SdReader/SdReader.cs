namespace SdReader
{
    public class SdReader : IUsb
    {
        private SdCard _sd;

        public SdReader(SdCard sd)
        {
            _sd = sd;
        }
        public void Request()
        {
            _sd.ReadAndWrite();
        }
    }
}