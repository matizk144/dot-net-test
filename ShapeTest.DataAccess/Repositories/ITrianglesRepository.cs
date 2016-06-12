using System.Collections.Generic;
using ShapeTest.DataAccess.Entities;

namespace ShapeTest.DataAccess.Repositories
{
    public interface ITrianglesRepository
    {
        event TriangleAddedEventHandler TriangleAdded;

        List<Triangle> GetTriangles();

        void AddTriangle(Triangle triangle);

        bool RemoveTriangle(Triangle triangle);
    }
}
