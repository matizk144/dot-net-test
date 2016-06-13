using System;
using ShapeTest.DataAccess.Entities.Base;
using ShapeTest.DataAccess.EventArgs;
using ShapeTest.DataAccess.EventArgs.Base;
using ShapeTest.DataAccess.Interfaces;

namespace ShapeTest.DataAccess.Repositories
{
    public class Repositories : IRepositories
    {
        public event EventHandler<BaseShapeEventArgs> ShapeAdded;
        public event EventHandler<BaseShapeEventArgs> ShapeRemoved;
        public ITrianglesRepository Triangles { get; }
        public ISquaresRepository Squares { get; }
        public IRectanglesRepository Rectangles { get; }
        public ICirclesRepository Circles { get; }

        public Repositories(ITrianglesRepository triangles, ISquaresRepository squares, IRectanglesRepository rectangles, ICirclesRepository circles)
        {
            Triangles = triangles;
            Squares = squares;
            Rectangles = rectangles;
            Circles = circles;

            Triangles.TriangleAdded += Triangles_TriangleAdded;
            Squares.SquareAdded += SquaresOnSquareAdded;
            Rectangles.RectangleAdded += Rectangles_RectangleAdded;
            Circles.CircleAdded += Circles_CircleAdded;

            Triangles.TriangleRemoved += Triangles_TriangleRemoved;
            Squares.SquareRemoved += Squares_SquareRemoved;
            Rectangles.RectangleRemoved += Rectangles_RectangleRemoved;
            Circles.CircleRemoved += Circles_CircleRemoved;
        }

        private void OnShapeRemoved(BaseShape removedShape)
        {
            ShapeRemoved?.Invoke(this, new BaseShapeEventArgs(removedShape));
        }

        private void Circles_CircleRemoved(object sender, CircleEventArgs e)
        {
            OnShapeRemoved(e.Entity);
        }

        private void Rectangles_RectangleRemoved(object sender, RectangleEventArgs e)
        {
            OnShapeRemoved(e.Entity);
        }

        private void Squares_SquareRemoved(object sender, SquareEventArgs e)
        {
            OnShapeRemoved(e.Entity);
        }

        private void Triangles_TriangleRemoved(object sender, TriangleEventArgs e)
        {
            OnShapeRemoved(e.Entity);
        }

        private void OnShapeAdded(BaseShape addedShape)
        {
            ShapeAdded?.Invoke(this, new BaseShapeEventArgs(addedShape));
        }

        private void Circles_CircleAdded(object sender, CircleEventArgs e)
        {
            OnShapeAdded(e.Entity);
        }

        private void Rectangles_RectangleAdded(object sender, RectangleEventArgs e)
        {
            OnShapeAdded(e.Entity);
        }

        private void SquaresOnSquareAdded(object sender, SquareEventArgs e)
        {
            OnShapeAdded(e.Entity);
        }

        private void Triangles_TriangleAdded(object sender, EventArgs.TriangleEventArgs e)
        {
            OnShapeAdded(e.Entity);
        }
    }
}