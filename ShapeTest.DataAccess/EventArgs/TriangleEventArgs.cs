using ShapeTest.DataAccess.Entities;
using ShapeTest.DataAccess.EventArgs.Base;

namespace ShapeTest.DataAccess.EventArgs
{
    public class TriangleEventArgs : BaseEntityEventArgs<Triangle>
    {
        public TriangleEventArgs(Triangle entity) : base(entity)
        {
        }
    }
}
