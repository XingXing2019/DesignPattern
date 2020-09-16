using System;
using ShapeAndColor.Color;
using ShapeAndColor.Shape;

namespace ShapeAndColor.Factory
{
    public class ShapeFactory : IFactory
    {
        public IShape GetShape(string shape)
        {
            var type = Type.GetType($"ShapeAndColor.Shape.{shape}");
            var obj = (IShape) Activator.CreateInstance(type, null);
            return obj;
        }

        public IColor GetColor(string color)
        {
            throw new System.NotImplementedException();
        }
    }
}