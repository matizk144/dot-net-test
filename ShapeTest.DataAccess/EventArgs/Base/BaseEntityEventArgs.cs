using ShapeTest.DataAccess.Entities.Base;

namespace ShapeTest.DataAccess.EventArgs.Base
{
    public abstract class BaseEntityEventArgs<TEntity> : System.EventArgs where TEntity : BaseEntity
    {
        private readonly TEntity _entity;

        protected BaseEntityEventArgs(TEntity entity)
        {
            _entity = entity;
        }

        public TEntity Entity
        {
            get { return _entity; }
        }
    }
}