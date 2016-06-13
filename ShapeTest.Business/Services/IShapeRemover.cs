using ShapeTest.DataAccess.Entities.Base;

namespace ShapeTest.Business.Services
{
    public interface IShapeRemover
    {
        void RemoveShape(BaseShape shape);
    }
}