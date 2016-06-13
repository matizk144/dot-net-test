using ShapeTest.DataAccess.Entities.Base;

namespace ShapeTest.DataAccess.EventArgs.Base
{
    public class BaseShapeEventArgs : BaseEntityEventArgs<BaseShape>
    {
        public BaseShapeEventArgs(BaseShape entity) : base(entity)
        {
        }
    }
}