using ShapeTest.DataAccess.Entities;
using ShapeTest.DataAccess.EventArgs.Base;

namespace ShapeTest.DataAccess.EventArgs
{
    public class RectangleEventArgs : BaseEntityEventArgs<Rectangle>
    {
        public RectangleEventArgs(Rectangle entity) : base(entity)
        {
        }
    }
}