using System;
using ShapeTest.DataAccess.Entities;
using ShapeTest.DataAccess.EventArgs;
using ShapeTest.DataAccess.Interfaces;
using ShapeTest.DataAccess.Repositories.BaseRepository;

namespace ShapeTest.DataAccess.Repositories
{
    public class RectanglesRepository : BaseRepository<Rectangle>, IRectanglesRepository
    {
        protected override void OnEntityRemoved(Rectangle entity)
        {
            RectangleRemoved?.Invoke(this, new RectangleEventArgs(entity));
        }

        protected override void OnEntityAdded(Rectangle entity)
        {
            RectangleAdded?.Invoke(this, new RectangleEventArgs(entity));
        }

        public event EventHandler<RectangleEventArgs> RectangleAdded;
        public event EventHandler<RectangleEventArgs> RectangleRemoved;
    }
}