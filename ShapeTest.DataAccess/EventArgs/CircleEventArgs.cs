using ShapeTest.DataAccess.Entities;
using ShapeTest.DataAccess.EventArgs.Base;

namespace ShapeTest.DataAccess.EventArgs
{
    public class CircleEventArgs : BaseEntityEventArgs<Circle>
    {
        public CircleEventArgs(Circle entity) : base(entity)
        {
        }
    }
}