using System.Collections.Generic;
using ShapeTest.DataAccess.Entities.Base;

namespace ShapeTest.DataAccess.Repositories.BaseRepository
{
    public abstract class BaseRepository<TEntity> where TEntity : BaseShape
    {
        protected List<TEntity> Entities;

        protected BaseRepository()
        {
            Entities = new List<TEntity>();
        }

        public List<TEntity> GetAll()
        {
            return Entities;
        }

        public void Add(TEntity entity)
        {
            Entities.Add(entity);
            OnEntityAdded(entity);
        }

        public void Remove(TEntity entity)
        {
            Entities.Remove(entity);
            OnEntityRemoved(entity);
        }

        protected abstract void OnEntityRemoved(TEntity entity);

        protected abstract void OnEntityAdded(TEntity entity);
    }
}