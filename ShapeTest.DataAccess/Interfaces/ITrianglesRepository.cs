using System;
using System.Collections.Generic;
using ShapeTest.DataAccess.Entities;
using ShapeTest.DataAccess.EventArgs;
using ShapeTest.DataAccess.EventHandlers;

namespace ShapeTest.DataAccess.Interfaces
{
    public interface ITrianglesRepository
    {
        event EventHandler<TriangleEventArgs> TriangleAdded;

        List<Triangle> GetTriangles();

        void AddTriangle(Triangle triangle);

        bool RemoveTriangle(Triangle triangle);
    }
}
