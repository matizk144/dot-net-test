using System;
using System.Collections.Generic;
using ShapeTest.DataAccess.Entities;
using ShapeTest.DataAccess.EventArgs;

namespace ShapeTest.DataAccess.Interfaces
{
    public interface ISquaresRepository
    {
        event EventHandler<SquareEventArgs> SquareAdded;
        event EventHandler<SquareEventArgs> SquareRemoved;

        List<Square> GetAll();

        void Add(Square square);

        void Remove(Square square);
    }
}