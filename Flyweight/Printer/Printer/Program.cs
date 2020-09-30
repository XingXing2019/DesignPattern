using System;

namespace Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeFaceFactory.SetTypeFace("hello", new WordTypeFace("hello"));
            TypeFaceFactory.GetTypeFace("hello").Print();
        }
    }
}
