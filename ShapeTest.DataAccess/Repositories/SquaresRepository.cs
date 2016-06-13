using System;
using ShapeTest.DataAccess.Entities;
using ShapeTest.DataAccess.EventArgs;
using ShapeTest.DataAccess.Interfaces;
using ShapeTest.DataAccess.Repositories.BaseRepository;

namespace ShapeTest.DataAccess.Repositories
{
    public class SquaresRepository : BaseRepository<Square>, ISquaresRepository
    {
        protected override void OnEntityRemoved(Square entity)
        {
            SquareRemoved?.Invoke(this, new SquareEventArgs(entity));
        }

        protected override void OnEntityAdded(Square entity)
        {
            SquareAdded?.Invoke(this, new SquareEventArgs(entity));
        }

        public event EventHandler<SquareEventArgs> SquareAdded;
        public event EventHandler<SquareEventArgs> SquareRemoved;
    }
}