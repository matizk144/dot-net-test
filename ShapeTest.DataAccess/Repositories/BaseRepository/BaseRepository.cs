using System.Collections.Generic;
using ShapeTest.DataAccess.Entities.Base;

namespace ShapeTest.DataAccess.Repositories.BaseRepository
{
    public abstract class BaseRepository<TEntity> where TEntity : BaseEntity
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

        public bool Remove(TEntity entity)
        {
            var removeStatus =  Entities.Remove(entity);
            OnEntityRemoved(entity, removeStatus);
            return removeStatus;
        }

        protected abstract bool OnEntityRemoved(TEntity entity, bool isRemoved);

        protected abstract void OnEntityAdded(TEntity entity);
    }
}