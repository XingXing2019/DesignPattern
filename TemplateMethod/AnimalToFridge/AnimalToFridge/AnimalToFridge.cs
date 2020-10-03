using System;

namespace AnimalToFridge
{
    public class AnimalToFridge
    {
        public void Do(Action beforePutInFridge, Action putInFridge)
        {
            OpenFridge();
            beforePutInFridge?.Invoke();
            putInFridge?.Invoke();
            CloseFridge();
        }

        private void OpenFridge()
        {
            Console.WriteLine("Open Fridge");
        }

        private void CloseFridge()
        {
            Console.WriteLine("Close Fridge");
        }
    }
}