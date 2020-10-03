using System;

namespace AnimalToFridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var elephant = new AnimalToFridge();
            elephant.Do(null, () => Console.WriteLine("Put elephant into fridge"));
            Console.WriteLine("----------------------");
            var giraffe = new AnimalToFridge();
            giraffe.Do(() => Console.WriteLine("Take elephant out"), () => Console.WriteLine("Put giraffe into fridge"));
        }
    }
}
