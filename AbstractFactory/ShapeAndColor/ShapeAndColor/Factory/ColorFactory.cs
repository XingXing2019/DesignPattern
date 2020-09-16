using System;
using ShapeAndColor.Color;
using ShapeAndColor.Shape;

namespace ShapeAndColor.Factory
{
    public class ColorFactory : IFactory
    {
        public IShape GetShape(string shape)
        {
            throw new System.NotImplementedException();
        }

        public IColor GetColor(string color)
        {
            var type = Type.GetType($"ShapeAndColor.Color.{color}");
            var obj = (IColor) Activator.CreateInstance(type, null);
            return obj;
        }
    }
}