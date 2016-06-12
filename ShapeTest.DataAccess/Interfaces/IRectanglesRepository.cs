using System;
using System.Collections.Generic;
using ShapeTest.DataAccess.Entities;
using ShapeTest.DataAccess.EventArgs;

namespace ShapeTest.DataAccess.Interfaces
{
    public interface IRectanglesRepository
    {
        event EventHandler<RectangleEventArgs> RectangleAdded;

        List<Rectangle> GetAll();

        void Add(Rectangle circle);

        bool Remove(Rectangle circle);
    }
}