using System;
using ShapeTest.DataAccess.Entities;
using ShapeTest.DataAccess.EventArgs;
using ShapeTest.DataAccess.Interfaces;
using ShapeTest.DataAccess.Repositories.BaseRepository;

namespace ShapeTest.DataAccess.Repositories
{
    public class CirclesRepository : BaseRepository<Circle>, ICirclesRepository
    {
        protected override void OnEntityRemoved(Circle entity)
        {
            CircleRemoved?.Invoke(this, new CircleEventArgs(entity));
        }

        protected override void OnEntityAdded(Circle entity)
        {
            CircleAdded?.Invoke(this, new CircleEventArgs(entity));
        }

        public event EventHandler<CircleEventArgs> CircleAdded;
        public event EventHandler<CircleEventArgs> CircleRemoved;
    }
}