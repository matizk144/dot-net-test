using ShapeTest.DataAccess.Entities.Base;

namespace ShapeTest.DataAccess.EventArgs.Base
{
    public class BaseEntityEventArgs<TEntity> : System.EventArgs where TEntity : BaseEntity
    {
        private readonly TEntity _entity;

        public BaseEntityEventArgs(TEntity entity)
        {
            _entity = entity;
        }

        public TEntity Entity
        {
            get { return _entity; }
        }
    }
}