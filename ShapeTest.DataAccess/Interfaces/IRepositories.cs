namespace ShapeTest.DataAccess.Interfaces
{
    public interface IRepositories
    {
        ITrianglesRepository Triangles { get; }
        ISquaresRepository Squares { get; }
        IRectanglesRepository Rectangles { get; }
        ICirclesRepository Circles { get; }
    }
}