using ShapeTest.DataAccess.Interfaces;

namespace ShapeTest.DataAccess.Repositories
{
    public class Repositories : IRepositories
    {
        public Repositories(ITrianglesRepository triangles, ISquaresRepository squares, IRectanglesRepository rectangles, ICirclesRepository circles)
        {
            Triangles = triangles;
            Squares = squares;
            Rectangles = rectangles;
            Circles = circles;
        }

        public ITrianglesRepository Triangles { get; }
        public ISquaresRepository Squares { get; }
        public IRectanglesRepository Rectangles { get; }
        public ICirclesRepository Circles { get; }
    }
}