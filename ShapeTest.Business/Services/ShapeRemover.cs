using System;
using ShapeTest.DataAccess.Entities;
using ShapeTest.DataAccess.Entities.Base;
using ShapeTest.DataAccess.Interfaces;

namespace ShapeTest.Business.Services
{
    public class ShapeRemover : IShapeRemover
    {
        private readonly IRepositories _repositories;

        public ShapeRemover(IRepositories repositories)
        {
            _repositories = repositories;
        }

        public void RemoveShape(BaseShape shape)
        {
            if (shape is Triangle)
            {
                RemoveTriangle(shape as Triangle);
            }
            else if (shape is Square)
            {
                RemoveSquare(shape as Square);
            }
            else if (shape is Rectangle)
            {
                RemoveRectangle(shape as Rectangle);
            }
            else if (shape is Circle)
            {
                RemoveCircle(shape as Circle);
            }
            else
            {
                throw new InvalidOperationException("Bad shape");
            }
        }

        private void RemoveCircle(Circle circle)
        {
            _repositories.Circles.Remove(circle);
        }

        private void RemoveRectangle(Rectangle rectangle)
        {

            _repositories.Rectangles.Remove(rectangle);
        }

        private void RemoveSquare(Square square)
        {
            _repositories.Squares.Remove(square);
        }

        private void RemoveTriangle(Triangle triangle)
        {
            _repositories.Triangles.Remove(triangle);
        }
    }
}