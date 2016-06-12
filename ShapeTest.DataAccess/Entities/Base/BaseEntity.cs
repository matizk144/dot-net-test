using System.Collections.Generic;
using ShapeTest.DataAccess.EventHandlers;

namespace ShapeTest.DataAccess.Entities.Base
{
    public class BaseEntity
    {
        public event EntityChangedEventHandler EntityChanged;

        public void SetAndRaiseIfChanged<T>(ref T backingField, T newValue)
        {
            if (!EqualityComparer<T>.Default.Equals(backingField, newValue))
            {
                backingField = newValue;
                OnEntityChanged();
            }
        }

        private void OnEntityChanged()
        {
            EntityChangedEventHandler handler = EntityChanged;
            handler?.Invoke(this, System.EventArgs.Empty);
        }
    }
}