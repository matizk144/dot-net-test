using System;
using ShapeTest.DataAccess.EventArgs.Base;

namespace ShapeTest.DataAccess.Interfaces
{
    public interface IRepositories
    {
        ITrianglesRepository Triangles { get; }
        ISquaresRepository Squares { get; }
        IRectanglesRepository Rectangles { get; }
        ICirclesRepository Circles { get; }

        event EventHandler<BaseShapeEventArgs> ShapeAdded;
        event EventHandler<BaseShapeEventArgs> ShapeRemoved;
    }
}