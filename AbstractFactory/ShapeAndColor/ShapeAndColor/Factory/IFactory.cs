using ShapeAndColor.Color;
using ShapeAndColor.Shape;

namespace ShapeAndColor.Factory
{
    public interface IFactory
    {
        IShape GetShape(string shape);
        IColor GetColor(string color);
    }
}