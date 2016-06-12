using System;
using System.Collections.Generic;
using ShapeTest.DataAccess.Entities;
using ShapeTest.DataAccess.EventArgs;

namespace ShapeTest.DataAccess.Interfaces
{
    public interface ITrianglesRepository
    {
        event EventHandler<TriangleEventArgs> TriangleAdded;

        List<Triangle> GetAll();

        void Add(Triangle triangle);

        bool Remove(Triangle triangle);
    }
}
