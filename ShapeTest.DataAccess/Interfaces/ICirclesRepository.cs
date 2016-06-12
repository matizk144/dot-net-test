using System;
using System.Collections.Generic;
using ShapeTest.DataAccess.Entities;
using ShapeTest.DataAccess.EventArgs;

namespace ShapeTest.DataAccess.Interfaces
{
    public interface ICirclesRepository
    {
        event EventHandler<CircleEventArgs> CircleAdded;

        List<Circle> GetAll();

        void Add(Circle circle);

        bool Remove(Circle circle);
    }
}