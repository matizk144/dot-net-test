using ShapeTest.DataAccess.Entities;
using ShapeTest.DataAccess.EventArgs.Base;

namespace ShapeTest.DataAccess.EventArgs
{
    public class SquareEventArgs : BaseEntityEventArgs<Square>
    {
        public SquareEventArgs(Square entity) : base(entity)
        {
        }
    }
}