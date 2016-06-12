using System;
using ShapeTest.DataAccess.Entities;
using ShapeTest.DataAccess.EventArgs;
using ShapeTest.DataAccess.Interfaces;
using ShapeTest.DataAccess.Repositories.BaseRepository;

namespace ShapeTest.DataAccess.Repositories
{
    public class SquaresRepository : BaseRepository<Square>, ISquaresRepository
    {
        protected override bool OnEntityRemoved(Square entity, bool isRemoved)
        {
            throw new NotImplementedException();
        }

        protected override void OnEntityAdded(Square entity)
        {
            SquareAdded?.Invoke(this, new SquareEventArgs(entity));
        }

        public event EventHandler<SquareEventArgs> SquareAdded;
    }
}