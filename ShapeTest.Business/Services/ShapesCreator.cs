using ShapeTest.Business.Enums;
using ShapeTest.DataAccess.Entities;
using ShapeTest.DataAccess.Interfaces;

namespace ShapeTest.Business.Services
{
    public class ShapesCreator : IShapesCreator
    {
        private readonly IRepositories _repositories;

        public ShapesCreator(IRepositories repositories)
        {
            _repositories = repositories;
        }

        public void AddShape(ShapeType shapeType)
        {
            switch (shapeType)
            {
                case ShapeType.Triangle:
                    CreateNewTriangle();
                    break;
                case ShapeType.Square:
                    CreateNewSquare();
                    break;
                case ShapeType.Rectangle:
                    CreateNewRectangle();
                    break;
                case ShapeType.Circle:
                    CreateNewCircle();
                    break;
            }
        }

        private void CreateNewCircle()
        {
            var circle = new Circle()
            {
                Name = "New Circle"
            };

            _repositories.Circles.Add(circle);
        }

        private void CreateNewRectangle()
        {
            var rectangle = new Rectangle()
            {
                Name = "New Rectangle"
            };

            _repositories.Rectangles.Add(rectangle);
        }

        private void CreateNewSquare()
        {
            var square = new Square()
            {
                Name = "New Square"
            };

            _repositories.Squares.Add(square);
        }

        private void CreateNewTriangle()
        {
            var triangle = new Triangle
            {
                Name = "New Triangle"
            };

            _repositories.Triangles.Add(triangle);
        }
    }
}