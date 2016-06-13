using System;
using System.Collections.Generic;
using ShapeTest.DataAccess.Entities;
using ShapeTest.DataAccess.EventArgs;

namespace ShapeTest.DataAccess.Interfaces
{
    public interface IRectanglesRepository
    {
        event EventHandler<RectangleEventArgs> RectangleAdded;
        event EventHandler<RectangleEventArgs> RectangleRemoved;

        List<Rectangle> GetAll();

        void Add(Rectangle circle);

        void Remove(Rectangle circle);
    }
}