using System;

namespace Printer
{
    public class WordTypeFace : TypeFace
    {
        private readonly string _word;

        public WordTypeFace(string word)
        {
            _word = word;
        }
        public override void Print()
        {
            Console.WriteLine(_word);
        }
    }
}