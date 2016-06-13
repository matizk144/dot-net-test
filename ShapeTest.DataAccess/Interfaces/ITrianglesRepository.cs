using System;
using System.Collections.Generic;
using ShapeTest.DataAccess.Entities;
using ShapeTest.DataAccess.EventArgs;

namespace ShapeTest.DataAccess.Interfaces
{
    public interface ITrianglesRepository
    {
        event EventHandler<TriangleEventArgs> TriangleAdded;
        event EventHandler<TriangleEventArgs> TriangleRemoved;

        List<Triangle> GetAll();

        void Add(Triangle triangle);

        void Remove(Triangle triangle);
    }
}
