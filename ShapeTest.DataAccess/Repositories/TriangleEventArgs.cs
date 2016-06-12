using System;
using ShapeTest.DataAccess.Entities;

namespace ShapeTest.DataAccess.Repositories
{
    public class TriangleEventArgs : EventArgs
    {
        public TriangleEventArgs(Triangle triangle)
        {
            Triangle = triangle;
        }

        public Triangle Triangle { get; }
    }
}
