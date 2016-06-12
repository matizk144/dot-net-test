using ShapeTest.Business.Enums;

namespace ShapeTest.Business.Services
{
    public interface IShapesCreator
    {
        void AddShape(ShapeType shapeType);
    }
}