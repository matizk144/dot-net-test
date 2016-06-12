using System;
using ShapeTest.DataAccess.Entities;
using ShapeTest.DataAccess.EventArgs;
using ShapeTest.DataAccess.Interfaces;
using ShapeTest.DataAccess.Repositories.BaseRepository;

namespace ShapeTest.DataAccess.Repositories
{
    public class CirclesRepository : BaseRepository<Circle>, ICirclesRepository
    {
        protected override bool OnEntityRemoved(Circle entity, bool isRemoved)
        {
            throw new NotImplementedException();
        }

        protected override void OnEntityAdded(Circle entity)
        {
            CircleAdded?.Invoke(this, new CircleEventArgs(entity));
        }

        public event EventHandler<CircleEventArgs> CircleAdded;
    }
}