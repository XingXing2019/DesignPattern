using System;

namespace ShapeAndColor.Factory
{
    public class FactoryProducer
    {
        public static IFactory GetFactory(string factory)
        {
            var type = Type.GetType($"ShapeAndColor.Factory.{factory}");
            var obj = (IFactory) Activator.CreateInstance(type, null);
            return obj;
        }
    }
}