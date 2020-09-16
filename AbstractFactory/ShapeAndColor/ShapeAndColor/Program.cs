using System;
using ShapeAndColor.Factory;

namespace ShapeAndColor
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = FactoryProducer.GetFactory("ShapeFactory");
            factory.GetShape("Circle").Draw();
            factory = FactoryProducer.GetFactory("ColorFactory");
            factory.GetColor("Red").Fill();
        }
    }
}
