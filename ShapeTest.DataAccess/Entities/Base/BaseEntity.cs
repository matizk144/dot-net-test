using System;
using System.Collections.Generic;

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
            handler?.Invoke(this, EventArgs.Empty);
        }
    }
}